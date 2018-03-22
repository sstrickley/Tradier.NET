namespace TradierClient
{
    using System.Collections.Generic;
    using System.Net.Http;

    public abstract class BaseFormEncodedRequest<TResponse> : BaseRequest<TResponse>
    {
        private Dictionary<string, string> postParams;

        public BaseFormEncodedRequest(AccessToken token, string endPoint) : base(token, endPoint)
        {
            postParams = new Dictionary<string, string>();
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

        public FormUrlEncodedContent GetFormEncodedContent()
        {
            return new FormUrlEncodedContent(postParams);
        }
    }
}
