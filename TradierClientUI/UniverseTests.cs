namespace TradierClientUI
{
    using System;
    using System.Threading.Tasks;
    using TradierClient;
    using TradierClient.Universe;

    public class UniverseTests
    {
        public static void TestLoadNYSE()
        {
            var request = new ExchangeRequest(Exchange.NYSE);
            var response = request.SendRequestAsync().GetAwaiter().GetResult();

            Console.WriteLine("Loaded {0} Stocks", response.Companies.Count);
        }

        public static void TestLoadNasdaq()
        {
            var request = new ExchangeRequest(Exchange.NASDAQ);
            var response = request.SendRequestAsync().GetAwaiter().GetResult();

            Console.WriteLine("Loaded {0} Stocks", response.Companies.Count);
        }

        public static void LoadSP500()
        {
            var reqeust = new IndexRequest(Index.SP500);
            var response = reqeust.SendRequestAsync().GetAwaiter().GetResult();

            Console.WriteLine("SP500 Loaded with {0} companies", response.Constituents.Count);
        }

        public static void LoadSP400()
        {
            var request = new IndexRequest(Index.SP400);
            var response = request.SendRequestAsync().GetAwaiter().GetResult();

            Console.WriteLine("SP400 Loaded with {0} companies", response.Constituents.Count);
        }
    }
}
