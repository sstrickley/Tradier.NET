namespace TradierClient.MarketData
{
    using System;
    using System.Collections.Concurrent;
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Net.Http.Headers;
    using System.Text;
    using System.Threading.Tasks;
    using System.Xml.Serialization;

    public class StreamingQuotesRequest
    {
        private AccessToken _token;
        private List<string> _symbols;
        private List<string> _filters;
        private Dictionary<string, string> _parameters;
        private SessionResponse _sessionData;

        public ConcurrentQueue<StreamData> Quotes { get; private set; }

        public event EventHandler<StreamData> QuoteReceivedEvent;
        public event EventHandler StreamDisconnectedEvent;

        public StreamingQuotesRequest(AccessToken token)
        {
            _token = token;
            Quotes = new ConcurrentQueue<StreamData>();
            _parameters = new Dictionary<string, string>();
            _symbols = new List<string>();
            _filters = new List<string>();

            _parameters.Add("linebreak", "true");
        }

        public void SetSymbol(string symbol)
        {
            _symbols.Add(symbol);
        }

        public void SetSymbol(List<string> symbolList)
        {
            _symbols = symbolList;
        }

        public void SetFilter(string filter)
        {
            _filters.Add(filter);
        }

        public void SetFilter(List<string> filter)
        {
            _filters = filter;
        }

        public async Task SendRequestAsync()
        {
            if (_symbols.Count > 0)
                _parameters.Add("symbols", string.Join(",", _symbols));

            if (_filters.Count > 0)
                _parameters.Add("filters", string.Join(",", _filters));

            await CreateStreamingSession();

            await SendHttpRequest();
            
        }

        private async Task CreateStreamingSession()
        {
            SessionRequest request = new SessionRequest(_token);
            _sessionData = await request.SendRequestAsync();

            _parameters.Add("sessionid", _sessionData.SessionID);
        }

        private async Task SendHttpRequest()
        {
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage message = await client.SendAsync(CreateRequestMessage(), HttpCompletionOption.ResponseHeadersRead);
                if (message.IsSuccessStatusCode)
                    await DeserializeResponse(message);
                else
                    throw new HttpRequestException(string.Format("HTTP Request failed Path!  Reason: {0}", message.ReasonPhrase));
            }  
        }

        private HttpRequestMessage CreateRequestMessage()
        {
            HttpRequestMessage message = new HttpRequestMessage();
            message.RequestUri = new Uri(_sessionData.URL);
            message.Method = HttpMethod.Post;
            message.Headers.Accept.Clear();
            message.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/xml"));
            message.Headers.Add("Authorization", string.Format("Bearer {0}", _token.access_token));
            message.Content = new FormUrlEncodedContent(_parameters);
            return message;
        }

        private async Task DeserializeResponse(HttpResponseMessage message)
        {
            try
            {
                using (StreamReader reader = new StreamReader(await message.Content.ReadAsStreamAsync()))
                {
                    while (!reader.EndOfStream)
                        DeserializeLine(reader.ReadLine());
                }
            }
            catch (IOException e)
            {
                StreamDisconnectedEvent?.Invoke(this, EventArgs.Empty);
                Console.WriteLine("IO Exception Caught!! {0} :: {1}", e.Message, e.InnerException.Message);
            }
        }

        private void DeserializeLine(string line)
        {
            MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(line));
            XmlSerializer ser = new XmlSerializer(typeof(StreamData));
            StreamData args = (StreamData)ser.Deserialize(ms);

            QuoteReceivedEvent?.Invoke(this, args);

            Quotes.Enqueue(args);
        }
    }
}
