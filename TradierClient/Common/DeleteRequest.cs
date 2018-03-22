namespace TradierClient
{
    using System.Net.Http;
    using System.Threading.Tasks;

    public abstract class DeleteRequest<TResponse> : BaseRequest<TResponse>
    {
        public DeleteRequest(AccessToken token, string endPoint) : base(token, endPoint)
        { }

        public override async Task<TResponse> SendRequestAsync()
        {
            using (HttpClient client = new HttpClient())
            {
                InitializeHttpClient(client);
                HttpResponseMessage message = await client.DeleteAsync(GetPath());
                return await ProcessResponseMessage(message);
            }
        }
    }
}
