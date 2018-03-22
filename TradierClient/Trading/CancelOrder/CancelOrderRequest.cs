namespace TradierClient.Trading
{
    using TradierClient.UserData;

    public class CancelOrderRequest : DeleteRequest<OrderStatusResponse>
    {
        public CancelOrderRequest(AccessToken token, Account account, Order order) : base(token, Endpoints.Request)
        {
            SetPath("accounts/{0}/orders{1}", account.AccountNumber, order.Id);
        }
    }
}
