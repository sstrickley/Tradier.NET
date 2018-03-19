namespace MtpLib.ApiRequests
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Threading.Tasks;
    using System.Xml.Serialization;

    public abstract class BaseFormEncodedPostRequest<TResponse>
    {
        private string _path;
        private Dictionary<string, string> postParams;

        public BaseFormEncodedPostRequest() : base()
        {
            postParams = new Dictionary<string, string>();
        }

        public void SetPath(string path)
        {
            _path = path;
        }

        public void AddPostParams(string key, string value)
        {
            postParams.Add(key, value);
        }

        public async Task<TResponse> SendRequestAsync()
        {
            using (HttpClient client = new HttpClient())
            {
                //client.BaseAddress = new Uri();
                client.Timeout = new TimeSpan(0, 1, 0);

                FormUrlEncodedContent content = new FormUrlEncodedContent(postParams);

                HttpResponseMessage message = await client.PostAsync(_path, content);

                //if (message.IsSuccessStatusCode)
                    return await DeserializeResponse(message);
                //else
                   // throw new HttpRequestException(string.Format("HTTP Request failed Path: {0}{1}", Settings.Default.BasePath, _path));
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
