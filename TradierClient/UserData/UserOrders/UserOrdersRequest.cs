namespace TradierClient.UserData
{
    public class UserOrdersRequest : BaseGetRequest<UserOrdersResponse>
    {
        public UserOrdersRequest(AccessToken token) : base(token.access_token, Endpoints.Request)
        {
            SetPath("user/orders");
        }
    }
}
