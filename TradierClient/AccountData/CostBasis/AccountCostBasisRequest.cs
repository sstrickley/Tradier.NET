namespace TradierClient.AccountData
{
    public class AccountCostBasisRequest : BaseGetRequest<AccountCostBasisResponse>
    {
        public AccountCostBasisRequest(AccessToken token, Account account) : base(token.access_token, Endpoints.Request)
        {
            SetPath(string.Format("accounts/{0}/gainloss", account.AccountNumber));
        }
    }
}
