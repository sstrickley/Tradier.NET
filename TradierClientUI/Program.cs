using System;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using TradierClient;

namespace TradierClientUI
{
    class Program
    {
        private static AccessToken _accessToken;
        private static Account _account;

        static void Main(string[] args)
        {
            try
            {
                LoadAccessToken();
                _account = UserDataTests.LoadUserAccount(_accessToken).Accounts.First();
                //UserDataTests.GetUserAccountHistory(_accessToken);
                //UserDataTests.GetUserBalances(_accessToken);
                //UserDataTests.GetUserPositions(_accessToken);
                //UserDataTests.GetUserCostBasis(_accessToken);
                //UserDataTests.GetUserOrders(_accessToken);

                //AccountDataTests.TestPositionsRequest(_accessToken, _account);
                //AccountDataTests.GetAccountBalances(_accessToken, _account);
                //AccountDataTests.GetAccountHistory(_accessToken, _account);
                //AccountDataTests.GetAccountCostBasis(_accessToken, _account);
                //AccountDataTests.GetAccountOrders(_accessToken, _account);
                //AccountDataTests.GetSpecificOrderDetails(_accessToken, _account, "123");

                // --------- THESE TESTS WILL CREATE A REAL ORDER! BE CAREFUL!! --------- //
                //TradeTests.TestPreviewOrder(_accessToken, _account);
                //TradeTests.TestCreateOrder();
                //TradeTests.TestChangeOrder();
                //TradeTests.TestCancelOrder();

                //MarketDataTests.TestQuotes(_accessToken);
                //MarketDataTests.TestTimeAndSales(_accessToken);
                //MarketDataTests.TestOptionChains(_accessToken);
                //MarketDataTests.TestOptionStrikes(_accessToken);
                //MarketDataTests.TestOptionExpirationDates(_accessToken);
                //MarketDataTests.TestHistoricalPricing(_accessToken);
                //MarketDataTests.TestIntradayStatus(_accessToken);
                //MarketDataTests.TestMarketCalendar(_accessToken);
                //MarketDataTests.TestCompanySearch(_accessToken);
                //MarketDataTests.TestSymbolLookup(_accessToken);
                //MarketDataTests.TestStreamingQuotes(_accessToken);

                //UniverseTests.TestLoadNYSE();
                //UniverseTests.TestLoadNasdaq();
                //UniverseTests.LoadSP500();
                UniverseTests.LoadSP400();
         

                Console.ReadLine();
            }
            catch(HttpRequestException hre)
            {
                Console.WriteLine("HTTP Request Failed!! {0}", hre.Message);
            }
            

            Console.ReadLine();
        }

        static void LoadAccessToken()
        {
            AccessTokenRequest request = new AccessTokenRequest();
            _accessToken = request.SendRequestAsync().GetAwaiter().GetResult();

            Console.WriteLine("Your Access Token has been loaded");
        }   
    }
}
