namespace TradierClientUI
{
    using System;
    using TradierClient;
    using TradierClient.AccountData;

    public class AccountDataTests
    {
        public static void TestPositionsRequest(AccessToken token, Account account)
        {
            AccountPositionsRequest request = new AccountPositionsRequest(token, account);
            PositionsResponse response = request.SendRequestAsync().GetAwaiter().GetResult();

            Console.WriteLine("Account Positions Loaded");
        }

        public static void GetAccountBalances(AccessToken token, Account account)
        {
            AccountBalancesRequest request = new AccountBalancesRequest(token, account);
            AccountBalancesResponse response = request.SendRequestAsync().GetAwaiter().GetResult();

            Console.WriteLine("Account Balances Loaded");
        }

        public static void GetAccountHistory(AccessToken token, Account account)
        {
            AccountHistoryRequest request = new AccountHistoryRequest(token, account);
            AccountHistoryResponse response = request.SendRequestAsync().GetAwaiter().GetResult();

            Console.WriteLine("Account History Loaded");
        }

        public static void GetAccountCostBasis(AccessToken token, Account account)
        {
            AccountCostBasisRequest request = new AccountCostBasisRequest(token, account);
            AccountCostBasisResponse response = request.SendRequestAsync().GetAwaiter().GetResult();

            Console.WriteLine("Account Cost Basis Loaded");
        }

        public static void GetAccountOrders(AccessToken token, Account account)
        {
            AccountOrdersRequest request = new AccountOrdersRequest(token, account);
            AccountOrdersResponse response = request.SendRequestAsync().GetAwaiter().GetResult();

            Console.WriteLine("Account Orders Loaded");
        }

        public static void GetSpecificOrderDetails(AccessToken token, Account account, string orderID)
        {
            SpecificOrderDetailsRequest request = new SpecificOrderDetailsRequest(token, account, orderID);
            SpecificOrderDetailsResponse response = request.SendRequestAsync().GetAwaiter().GetResult();

            Console.WriteLine("Specific Order Details Loaded");
        }
    }
}
