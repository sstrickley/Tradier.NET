namespace TradierClient.Trading
{
    public class CreateOrderRequest : FormEncodedPostRequest<OrderStatusResponse>
    {
        public CreateOrderRequest(AccessToken token, Account account, IOrderForm orderForm) : base(token, Endpoints.Request)
        {
            SetPath("accounts/{0}/orders", account.AccountNumber);
            AddPostParams(orderForm.GetPostParameters());
        }
    }
}
