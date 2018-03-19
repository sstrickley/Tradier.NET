namespace TradierClient.AccountData
{
    public class AccountBalancesRequest : BaseGetRequest<AccountBalancesResponse>
    {
        public AccountBalancesRequest(AccessToken token, Account account) : base(token.access_token, Endpoints.Request)
        {
            SetPath(string.Format("accounts/{0}/balances", account.AccountNumber));
        }
    }
}
