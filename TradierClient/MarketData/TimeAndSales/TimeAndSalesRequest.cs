namespace TradierClient.MarketData
{
    using System;
    using System.Globalization;
    using System.Threading.Tasks;

    public class TimeAndSalesRequest : GetRequest<TimeAndSalesResponse>
    { 
        public TimeAndSalesRequest(AccessToken token, string symbol) : base(token, Endpoints.Request)
        {
            Parameters.Add("symbol", symbol);
        }

        public void SetInterval(TimeAndSalesInterval interval)
        {
            Parameters.Add("interval", interval.GetDescription().ToLower());
        }

        public void SetStartDate(DateTime startDate)
        {
            Parameters.Add("start", startDate.ToString("yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture));
        }

        public void SetEndDate(DateTime endDate)
        {
            Parameters.Add("end", endDate.ToString("yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture));
        }

        public void SetSessionFilter(SessionFilter filter)
        {
            Parameters.Add("session_filter", filter.ToString().ToLower());
        }

        public override async Task<TimeAndSalesResponse> SendRequestAsync()
        {
            SetPath("markets/timesales?{0}", GetFormatedParams());

            return await base.SendRequestAsync();
        }
    }
}
