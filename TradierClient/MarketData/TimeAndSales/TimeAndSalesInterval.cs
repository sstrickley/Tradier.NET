namespace TradierClient.MarketData
{
    using System.ComponentModel;

    public enum TimeAndSalesInterval
    {
        Tick,

        [Description("1min")]
        OneMin,

        [Description("5min")]
        FiveMin,

        [Description("15min")]
        FifteenMin
    }
}
