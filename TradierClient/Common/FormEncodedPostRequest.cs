namespace TradierClient
{
    using System.Net.Http;
    using System.Threading.Tasks;

    public abstract class FormEncodedPostRequest<TResponse> : BaseFormEncodedRequest<TResponse>
    {  
        public FormEncodedPostRequest(AccessToken token, string endPoint) : base(token, endPoint)
        { }

        public override async Task<TResponse> SendRequestAsync()
        {
            await RequestManager.I.Throttle();

            using (HttpClient client = new HttpClient())
            {
                InitializeHttpClient(client);
                FormUrlEncodedContent content = GetFormEncodedContent();
                HttpResponseMessage message = await client.PostAsync(GetPath(), content);

                return await ProcessResponseMessage(message);
            }
        }
    }
}
