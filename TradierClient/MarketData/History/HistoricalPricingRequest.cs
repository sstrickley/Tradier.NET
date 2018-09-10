namespace TradierClient.MarketData
{
    using System;
    using System.Threading.Tasks;

    public class HistoricalPricingRequest : GetRequest<HistoricalPricingResponse>
    {
        public HistoricalPricingRequest(AccessToken token, string symbol) : base(token, Endpoints.Request)
        {
            Parameters.Add("symbol", symbol);
        }

        public void SetInterval(HistoryInterval interval)
        {
            Parameters.Add("interval", interval.ToString().ToLower());
        }

        public void SetStartDate(DateTime start)
        {
            Parameters.Add("start", start.ToString("yyyy-MM-dd"));
        }

        public void SetEndDate(DateTime end)
        {
            Parameters.Add("end", end.ToString("yyyy-MM-dd")); 
        }

        public void SetPast_Days(double days)
        {
            SetStartDate(DateTime.Today.AddDays(-days));
        }

        public override async Task<HistoricalPricingResponse> SendRequestAsync()
        {
            SetPath("markets/history?{0}", GetFormatedParams());

            return await base.SendRequestAsync();
        }
    }

    public enum HistoryInterval
    {
        Daily,
        Weekly,
        Monthly
    }
}
