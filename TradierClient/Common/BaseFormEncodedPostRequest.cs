namespace TradierClient
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Net.Http.Headers;
    using System.Threading.Tasks;
    using System.Xml.Serialization;

    public abstract class BaseFormEncodedPostRequest<TResponse> : IRequest<TResponse>
    {
        private string _path;
        private Uri _baseUri;
        private Dictionary<string, string> postParams;
        private string _accessToken;

        public BaseFormEncodedPostRequest(string token, string endPoint)
        {
            postParams = new Dictionary<string, string>();
            _accessToken = token;
            _baseUri = new Uri(endPoint);
        }

        public void SetPath(string baseString, params string[] args)
        {
            SetPath(string.Format(baseString, args));
        }

        public void SetPath(string path)
        {
            _path = path;
        }

        public void AddPostParams(Dictionary<string, string> keyValuePairs)
        {
            foreach (KeyValuePair<string, string> kvp in keyValuePairs)
                postParams.Add(kvp.Key, kvp.Value);
        }

        public void AddPostParams(string key, string value)
        {
            postParams.Add(key, value);
        }

        public async Task<TResponse> SendRequestAsync()
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = _baseUri;
                client.Timeout = new TimeSpan(0, 1, 0);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/xml"));
                client.DefaultRequestHeaders.Add("Authorization", string.Format("Bearer {0}", _accessToken));

                FormUrlEncodedContent content = new FormUrlEncodedContent(postParams);

                HttpResponseMessage message = await client.PostAsync(_path, content);

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
