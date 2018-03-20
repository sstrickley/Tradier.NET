using System;
using TradierClient;
using TradierClient.Trading;

namespace TradierClientUI
{
    public class TradeTests
    {
        public static void TestPreviewOrder(AccessToken token, Account account)
        {
            IOrderForm orderForm = OrderForm.CreateBuyLimitOrder("ON", 2, 95.5m);
            PreviewRequest request = new PreviewRequest(token, account, orderForm);
            PreviewResponse response = request.SendRequestAsync().GetAwaiter().GetResult();

            Console.WriteLine("Order Preview Status {0}", response.Status);
    
        }
    }
}
