namespace TradierClient.UserData
{
    public class BalancesRequest : BaseGetRequest<BalancesResponse>
    {
        public BalancesRequest(AccessToken token) : base(token.access_token, Endpoints.Request)
        {
            SetPath("user/balances");
        }
    }
}
