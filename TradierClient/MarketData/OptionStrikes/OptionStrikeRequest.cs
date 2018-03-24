namespace TradierClient.MarketData
{
    using System;
    using System.Globalization;

    public class OptionStrikeRequest : GetRequest<OptionStrikeResponse>
    {
        public OptionStrikeRequest(AccessToken token, string symbol, DateTime expiration) : base(token, Endpoints.Request)
        {
            SetPath("markets/options/strikes?symbol={0}&expiration={1}",
                symbol,
                expiration.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture));
        }
    }
}
