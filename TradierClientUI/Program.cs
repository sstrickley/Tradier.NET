using System;
using System.Linq;
using System.Net.Http;
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
                AccountDataTests.GetSpecificOrderDetails(_accessToken, _account, "123");
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
