namespace TradierClient
{
    using System.Net.Http;
    using System.Threading.Tasks;

    public abstract class FormEncodedPutRequest<TResponse> : BaseFormEncodedRequest<TResponse>  
    {
        public FormEncodedPutRequest(AccessToken token, string endPoint) : base(token, endPoint)
        { }

        public override async Task<TResponse> SendRequestAsync()
        {
            await RequestManager.I.Throttle();

            using (HttpClient client = new HttpClient())
            {
                InitializeHttpClient(client);
                FormUrlEncodedContent content = GetFormEncodedContent();
                HttpResponseMessage message = await client.PutAsync(GetPath(), content);

                return await ProcessResponseMessage(message);
            }
        }
    }
}
