namespace TradierClient.AccountData
{
    public class AccountCostBasisRequest : GetRequest<AccountCostBasisResponse>
    {
        public AccountCostBasisRequest(AccessToken token, Account account) : base(token, Endpoints.Request)
        {
            SetPath("accounts/{0}/gainloss", account.AccountNumber);
        }
    }
}
