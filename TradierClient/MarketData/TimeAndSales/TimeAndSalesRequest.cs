using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace TradierClient.MarketData
{
    public class TimeAndSalesRequest : GetRequest<TimeAndSalesResponse>
    {
        private Dictionary<string, string> _parameters;

        public TimeAndSalesRequest(AccessToken token, string symbol) : base(token, Endpoints.Request)
        {
            _parameters = new Dictionary<string, string>();
            _parameters.Add("symbol", symbol);
        }

        public void SetInterval(TimeAndSalesInterval interval)
        {
            _parameters.Add("interval", interval.GetDescription().ToLower());
        }

        public void SetStartDate(DateTime startDate)
        {
            _parameters.Add("start", startDate.ToString("yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture));
        }

        public void SetEndDate(DateTime endDate)
        {
            _parameters.Add("end", endDate.ToString("yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture));
        }

        public void SetSessionFilter(SessionFilter filter)
        {
            _parameters.Add("session_filter", filter.ToString().ToLower());
        }

        public override async Task<TimeAndSalesResponse> SendRequestAsync()
        {
            SetPath("markets/timesales?{0}", 
                string.Join("&", _parameters
                    .Select(k => string.Format("{0}={1}", k.Key, k.Value))));

            return await base.SendRequestAsync();
        }
    }
}
