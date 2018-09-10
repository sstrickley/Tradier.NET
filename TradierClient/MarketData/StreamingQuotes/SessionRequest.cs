namespace TradierClient.MarketData
{
    public class SessionRequest : FormEncodedPostRequest<SessionResponse>
    {
        public SessionRequest(AccessToken token) : base(token, Endpoints.Request)
        {
            SetPath("markets/events/session");
        }
    }
}
