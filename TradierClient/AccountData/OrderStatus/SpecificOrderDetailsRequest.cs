namespace TradierClient.AccountData
{
    public class SpecificOrderDetailsRequest : BaseGetRequest<SpecificOrderDetailsResponse>
    {
        public SpecificOrderDetailsRequest(AccessToken token, Account account, string orderID) : base(token.access_token, Endpoints.Request)
        {
            SetPath("accounts/{0}/orders/{1}", account.AccountNumber, orderID);
        }
    }
}
