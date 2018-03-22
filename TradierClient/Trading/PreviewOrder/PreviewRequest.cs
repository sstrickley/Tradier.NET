namespace TradierClient.Trading
{
    public class PreviewRequest : FormEncodedPostRequest<PreviewResponse>
    {
        public PreviewRequest(AccessToken token, Account account, IOrderForm orderForm) : base(token, Endpoints.Request)
        {
            SetPath("accounts/{0}/orders", account.AccountNumber);
            AddPostParams(orderForm.GetPostParameters());
            AddPostParams("preview", "true");
        }
    }
}
