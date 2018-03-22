namespace TradierClient
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Net.Http.Headers;
    using System.Threading.Tasks;
    using System.Xml.Serialization;

    public abstract class BaseRequest<TResponse>
    {
        private Uri _baseUri;
        private string _accessToken;
        private string _path;

        public BaseRequest()
        { }

        public BaseRequest(AccessToken token, string endPoint)
        {
            _baseUri = new Uri(endPoint);
            _accessToken = token.access_token;
        }

        public void SetPath(string baseString, params string[] args)
        {
            SetPath(string.Format(baseString, args));
        }

        public void SetPath(string path)
        {
            _path = path;
        }

        public string GetPath()
        {
            return _path;
        }

        public abstract Task<TResponse> SendRequestAsync();

        protected void InitializeHttpClient(HttpClient client)
        {
            client.BaseAddress = _baseUri;
            client.Timeout = new TimeSpan(0, 1, 0);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/xml"));
            client.DefaultRequestHeaders.Add("Authorization", string.Format("Bearer {0}", _accessToken));
        }

        protected async Task<TResponse> ProcessResponseMessage(HttpResponseMessage message)
        {
            if (message.IsSuccessStatusCode)
                return await DeserializeResponse(message);
            else if (message.ReasonPhrase.ToUpper() == "BAD REQUEST")
                throw new HttpRequestException(string.Format("Bad Request!! Reason {0}", await GetResponseAsString(message)));
            else
                throw new HttpRequestException(string.Format("HTTP Request failed Path!  Reason: {0}", message.ReasonPhrase));
        }

        private async Task<TResponse> DeserializeResponse(HttpResponseMessage message)
        {
            using (StreamReader reader = new StreamReader(await message.Content.ReadAsStreamAsync()))
            {
                // Console.WriteLine(reader.ReadToEnd());

                XmlSerializer ser = new XmlSerializer(typeof(TResponse));
                return (TResponse)ser.Deserialize(reader);
            }
        }

        private async Task<string> GetResponseAsString(HttpResponseMessage message)
        {
            using (StreamReader reader = new StreamReader(await message.Content.ReadAsStreamAsync()))
            {
                return await reader.ReadToEndAsync();
            }
        }
    }
}
