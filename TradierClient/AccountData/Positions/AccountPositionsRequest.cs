namespace TradierClient.AccountData
{
    public class AccountPositionsRequest : GetRequest<PositionsResponse>
    {
        public AccountPositionsRequest(AccessToken token, Account account) : base(token, Endpoints.Request)
        {
            SetPath("accounts/{0}/positions", account.AccountNumber);
        }
    }
}
