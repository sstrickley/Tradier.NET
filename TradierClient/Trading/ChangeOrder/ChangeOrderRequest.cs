namespace TradierClient.Trading
{
    using TradierClient.UserData;

    public class ChangeOrderRequest : FormEncodedPutRequest<OrderStatusResponse>
    {
        public ChangeOrderRequest(AccessToken token, Account account, Order order) : base(token, Endpoints.Request)
        {
            SetPath("accounts/{0}/orders/{1}", account.AccountNumber, order.Id);
        }

        public void SetType(OrderType type)
        {
            AddPostParams("type", type.ToString());
        }

        public void SetDuration(OrderDuration duration)
        {
            AddPostParams("duration", duration.ToString());
        }

        public void SetPrice(decimal price)
        {
            AddPostParams("price", price.ToString());
        }

        public void SetStop(decimal stop)
        {
            AddPostParams("stop", stop.ToString());
        }
    }
}
