namespace TradierClient.MarketData
{
    public class IntradayStatusRequest : GetRequest<IntradayStatusResponse>
    {
        public IntradayStatusRequest(AccessToken token) : base(token, Endpoints.Request)
        {
            SetPath("markets/clock");
        }
    }
}
