namespace TradierClient.AccountData
{
    public class AccountOrdersRequest : GetRequest<AccountOrdersResponse>
    {
        public AccountOrdersRequest(AccessToken token, Account account) : base(token, Endpoints.Request)
        {
            SetPath("accounts/{0}/orders", account.AccountNumber);
        }
    }
}
