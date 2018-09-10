namespace TradierClient.MarketData
{
    public class OptionExpireRequest : GetRequest<OptionExpireResponse>
    {
        public OptionExpireRequest(AccessToken token, string symbol) : base(token, Endpoints.Request)
        {
            SetPath("markets/options/expirations?symbol={0}", symbol);
        }
    }
}
