namespace TradierClient.UserData
{
    public class UserOrdersRequest : GetRequest<UserOrdersResponse>
    {
        public UserOrdersRequest(AccessToken token) : base(token, Endpoints.Request)
        {
            SetPath("user/orders");
        }
    }
}
