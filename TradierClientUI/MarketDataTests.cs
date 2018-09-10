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

        public static void TestOptionExpirationDates(AccessToken token)
        {
            OptionExpireRequest request = new OptionExpireRequest(token, "ON");
            OptionExpireResponse response = request.SendRequestAsync().GetAwaiter().GetResult();

            Console.WriteLine("Request successfull");
        }

        public static void TestHistoricalPricing(AccessToken token)
        {
            HistoricalPricingRequest request = new HistoricalPricingRequest(token, "ON");
            request.SetPast_Days(30);

            HistoricalPricingResponse response = request.SendRequestAsync().GetAwaiter().GetResult();

            Console.WriteLine("Request successfull");
        }

        public static void TestIntradayStatus(AccessToken token)
        {
            IntradayStatusRequest request = new IntradayStatusRequest(token);
            IntradayStatusResponse response = request.SendRequestAsync().GetAwaiter().GetResult();

            Console.WriteLine("Request successfull");
        }

        public static void TestMarketCalendar(AccessToken token)
        {
            MarketCalendarRequest request = new MarketCalendarRequest(token);
            request.SetMonthYear(1, 2018);
            MarketCalendarResponse response = request.SendRequestAsync().GetAwaiter().GetResult();

            Console.WriteLine("Request successfull");
        }

        public static void TestCompanySearch(AccessToken token)
        {
            CompanySearchRequest request = new CompanySearchRequest(token, "Apple");
            request.IncludeIndexes();
            CompanySearchResponse response = request.SendRequestAsync().GetAwaiter().GetResult();

            Console.WriteLine("Request successfull");
        }

        public static void TestSymbolLookup(AccessToken token)
        {
            SymbolLookupRequest request = new SymbolLookupRequest(token);
            request.SetExchangeCode("F");
            request.SetExchangeCode("A");
            request.SetType(SecurityType.stock);

            CompanySearchResponse response = request.SendRequestAsync().GetAwaiter().GetResult();

            Console.WriteLine("Request successfull");
        }

        public static void TestStreamingQuotes(AccessToken token)
        {
            StreamingQuotesRequest request = new StreamingQuotesRequest(token);
            request.SetSymbol("ON");
            request.QuoteReceivedEvent += OnQuoteReceived;

            request.SendRequestAsync().GetAwaiter().GetResult();
        }

        private static void OnQuoteReceived(object sender, StreamData args)
        {
            Console.WriteLine("{0} {1} {2}", args.Type, args.Symbol, args.Price);
        }
    }
}
