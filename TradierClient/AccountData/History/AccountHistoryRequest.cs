namespace TradierClient.AccountData
{
    public class AccountHistoryRequest : GetRequest<AccountHistoryResponse>
    {
        public AccountHistoryRequest(AccessToken token, Account account) : base(token, Endpoints.Request)
        {
            SetPath("accounts/{0}/history", account.AccountNumber);
        }
    }
}
