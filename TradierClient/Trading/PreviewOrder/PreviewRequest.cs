namespace TradierClient.Trading
{
    public class PreviewRequest : BaseFormEncodedPostRequest<PreviewResponse>
    {
        public PreviewRequest(AccessToken token, Account account, IOrderForm orderForm) : base(token.access_token, Endpoints.Request)
        {
            SetPath("accounts/{0}/orders", account.AccountNumber);
            AddPostParams(orderForm.GetPostParameters());
            AddPostParams("preview", "true");
        }
    }
}
