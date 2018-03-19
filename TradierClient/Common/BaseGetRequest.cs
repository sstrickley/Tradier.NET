namespace TradierClient
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Net.Http.Headers;
    using System.Threading.Tasks;
    using System.Xml.Serialization;

    public abstract class BaseGetRequest<TResponse> : IRequest<TResponse>
    {
        private string _path;
        private string _accessToken;
        private Uri _baseUri;

        public BaseGetRequest(string accessToken, string ept)
        {
            _baseUri = new Uri(ept);
            _accessToken = accessToken;
        }

        public void SetPath(string path)
        {
            _path = path;
        }

        public virtual async Task<TResponse> SendRequestAsync()
        {
            using(HttpClient client = new HttpClient())
            {
                client.BaseAddress = _baseUri;
                client.Timeout = new TimeSpan(0, 1, 0);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/xml"));
                client.DefaultRequestHeaders.Add("Authorization", string.Format("Bearer {0}", _accessToken));

                HttpResponseMessage message = await client.GetAsync(_path);

               if (message.IsSuccessStatusCode)
                    return await DeserializeResponse(message);
                else
                    throw new HttpRequestException(string.Format("HTTP Request failed Path: {0}{1}", _baseUri.AbsolutePath, _path));
            }            
        }

        private async Task<TResponse> DeserializeResponse(HttpResponseMessage message)
        {
            using (StreamReader reader = new StreamReader(await message.Content.ReadAsStreamAsync()))
            {
                //Console.WriteLine(reader.ReadToEnd());

                XmlSerializer ser = new XmlSerializer(typeof(TResponse));
                return (TResponse)ser.Deserialize(reader); 
            }
        }
    }
}
