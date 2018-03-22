namespace TradierClient.AccountData
{
    public class AccountBalancesRequest : GetRequest<AccountBalancesResponse>
    {
        public AccountBalancesRequest(AccessToken token, Account account) : base(token, Endpoints.Request)
        {
            SetPath("accounts/{0}/balances", account.AccountNumber);
        }
    }
}
