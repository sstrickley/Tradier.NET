namespace TradierClient.UserData
{
    public class AccountHistoryRequest : GetRequest<AccountHistoryResponse>
    {
        public AccountHistoryRequest(AccessToken token) : base(token, Endpoints.Request)
        {
            SetPath("user/history");
        }
    }
}
