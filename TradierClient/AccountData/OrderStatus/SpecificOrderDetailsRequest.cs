namespace TradierClient.AccountData
{
    public class SpecificOrderDetailsRequest : GetRequest<SpecificOrderDetailsResponse>
    {
        public SpecificOrderDetailsRequest(AccessToken token, Account account, string orderID) : base(token, Endpoints.Request)
        {
            SetPath("accounts/{0}/orders/{1}", account.AccountNumber, orderID);
        }
    }
}
