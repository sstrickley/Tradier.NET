namespace TradierClient.MarketData
{
    using System;
    using System.Globalization;

    public class OptionChainRequest : GetRequest<OptionChainResponse>
    {
        public OptionChainRequest(AccessToken token, string symbol, DateTime expiration) :base(token, Endpoints.Request)
        {
            SetPath("markets/options/chains?symbol={0}&expiration={1}",
                symbol,
                expiration.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture));
        }
    }
}
