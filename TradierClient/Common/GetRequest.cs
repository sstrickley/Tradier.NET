namespace TradierClient
{
    using System.Net.Http;
    using System.Threading.Tasks;

    public abstract class GetRequest<TResponse> : BaseRequest<TResponse>
    {
        public GetRequest(AccessToken token, string ept) : base(token, ept)
        { }

        public override async Task<TResponse> SendRequestAsync()
        {
            using(HttpClient client = new HttpClient())
            {
                InitializeHttpClient(client);
                HttpResponseMessage message = await client.GetAsync(GetPath());
                return await ProcessResponseMessage(message);
            }            
        }  
    }
}
