using System;
using System.Collections.Generic;
using TradierClient;
using TradierClient.MarketData;

namespace TradierClientUI
{
    public class MarketDataTests
    {
        public static void TestQuotes(AccessToken token)
        {
            string symbol = "ON";

            List<string> symbols = new List<string>();
            symbols.Add(symbol);
            symbols.Add("AAPL");
            symbols.Add("NVCR");

            QuoteRequest request = new QuoteRequest(token, symbols);
            QuoteResponse response = request.SendRequestAsync().GetAwaiter().GetResult();

            Console.WriteLine("Quote Loaded");
        }

        public static void TestTimeAndSales(AccessToken token)
        {
            TimeAndSalesRequest request = new TimeAndSalesRequest(token, "ON");
            request.SetInterval(TimeAndSalesInterval.FifteenMin);
            request.SetStartDate(DateTime.Now.AddDays(-2));
            request.SetEndDate(DateTime.Now.AddDays(-1));
            request.SetSessionFilter(SessionFilter.Open);

            TimeAndSalesResponse response = request.SendRequestAsync().GetAwaiter().GetResult();

            Console.WriteLine("Request successfull");
        }

        public static void TestOptionChains(AccessToken token)
        {
            OptionChainRequest request = new OptionChainRequest(token, "ON", new DateTime(2018, 04, 20));
            OptionChainResponse response = request.SendRequestAsync().GetAwaiter().GetResult();

            Console.WriteLine("Request successfull");
        }

        public static void TestOptionStrikes(AccessToken token)
        {
            OptionStrikeRequest request = new OptionStrikeRequest(token, "ON", new DateTime(2018, 04, 20));
            OptionStrikeResponse response = request.SendRequestAsync().GetAwaiter().GetResult();

            Console.WriteLine("Request successfull");
        }
    }
}
