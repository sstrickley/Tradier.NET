namespace TradierClient.MarketData
{
    using System;
    using System.Threading.Tasks;

    public class MarketCalendarRequest : GetRequest<MarketCalendarResponse>
    {
        public MarketCalendarRequest(AccessToken token) : base(token, Endpoints.Request)
        { }

        public void SetMonthYear(DateTime date)
        {
            SetMonthYear(date.Month, date.Year);
        }

        public void SetMonthYear(int month, int year)
        {
            Parameters.Add("month", month.ToString());
            Parameters.Add("year", year.ToString());
        }

        public override async Task<MarketCalendarResponse> SendRequestAsync()
        {
            SetPath("markets/calendar?{0}", GetFormatedParams());

            return await base.SendRequestAsync();
        }
    }
}
