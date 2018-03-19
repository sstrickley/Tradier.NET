namespace TradierClientUI
{
    using System;
    using TradierClient;
    using TradierClient.UserData;

    public class UserDataTests
    {
        public static ProfileResponse LoadUserAccount(AccessToken token)
        {
            ProfileRequest request = new ProfileRequest(token);
            ProfileResponse response = request.SendRequestAsync().GetAwaiter().GetResult();

            Console.WriteLine("Hello {0}! Your account info as been loaded", response.Name);

            return response;
        }

        public static void GetUserBalances(AccessToken token)
        {
            BalancesRequest request = new BalancesRequest(token);
            BalancesResponse response = request.SendRequestAsync().GetAwaiter().GetResult();

            Console.WriteLine("Balances Loaded");
        }

        public static void GetUserPositions(AccessToken token)
        {
            PositionsRequest request = new PositionsRequest(token);
            PositionResponse response = request.SendRequestAsync().GetAwaiter().GetResult();

            Console.WriteLine("Positions Loaded");
        }

        public static void GetUserAccountHistory(AccessToken token)
        {
            AccountHistoryRequest request = new AccountHistoryRequest(token);
            AccountHistoryResponse response = request.SendRequestAsync().GetAwaiter().GetResult();

            Console.WriteLine("Account History Loaded");
        }

        public static void GetUserCostBasis(AccessToken token)
        {
            UserCostBasisRequest request = new UserCostBasisRequest(token);
            UserCostBasisResponse response = request.SendRequestAsync().GetAwaiter().GetResult();

            Console.WriteLine("Cost basis loaded");
        }

        public static void GetUserOrders(AccessToken token)
        {
            UserOrdersRequest request = new UserOrdersRequest(token);
            UserOrdersResponse response = request.SendRequestAsync().GetAwaiter().GetResult();

            Console.WriteLine("User orders loaded");
        }
    }
}
