namespace TradierClient.UserData
{
    public class AccountHistoryRequest : BaseGetRequest<AccountHistoryResponse>
    {
        public AccountHistoryRequest(AccessToken token) : base(token.access_token, Endpoints.Request)
        {
            SetPath("user/history");
        }
    }
}
