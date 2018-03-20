namespace TradierClient.Trading
{
    public class CreateOrderRequest : BaseFormEncodedPostRequest<CreateOrderResponse>
    {
        public CreateOrderRequest(AccessToken token, Account account, IOrderForm orderForm) : base(token.access_token, Endpoints.Request)
        {
            SetPath("accounts/{0}/orders", account.AccountNumber);
            AddPostParams(orderForm.GetPostParameters());
        }
    }
}
