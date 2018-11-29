namespace TradierClient
{
    using System;
    using System.Linq;
    using System.Net.Http;
    using System.Threading.Tasks;

    public abstract class GetRequest<TResponse> : BaseRequest<TResponse>
    {
        public GetRequest(AccessToken token, string ept) : base(token, ept)
        { }

        public GetRequest(string ept) : base(ept)
        { }

        public string GetFormatedParams()
        {
            return string.Join("&", Parameters
                    .Select(k => string.Format("{0}={1}", k.Key, k.Value)));
        }

        public override async Task<TResponse> SendRequestAsync()
        {
            await RequestManager.I.Throttle();

            using(HttpClient client = new HttpClient())
            {
                try
                {
                    InitializeHttpClient(client);
                    HttpResponseMessage message = await client.GetAsync(GetPath()).ConfigureAwait(false);
                    return await ProcessResponseMessage(message);
                }
                catch(Exception e)
                {
                    System.Console.WriteLine(e.Message);
                    throw e;
                }
                
            }            
        }  
    }
}
