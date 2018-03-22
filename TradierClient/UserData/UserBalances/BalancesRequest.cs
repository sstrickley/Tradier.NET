namespace TradierClient.UserData
{
    public class BalancesRequest : GetRequest<BalancesResponse>
    {
        public BalancesRequest(AccessToken token) : base(token, Endpoints.Request)
        {
            SetPath("user/balances");
        }
    }
}
