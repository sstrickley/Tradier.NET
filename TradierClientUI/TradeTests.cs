using System;
using TradierClient;
using TradierClient.Trading;
using TradierClient.AccountData;
using TradierClient.UserData;
using System.Linq;

namespace TradierClientUI
{
    public class TradeTests
    {
        private static IOrderForm _form;
        private static AccessToken _token;
        private static Account _account;

        public static void TestPreviewOrder(AccessToken token, Account account)
        {
            _form = OrderForm.CreateBuyLimitOrder("ON", 2, 95.5m);
            _token = token;
            _account = account;

            PreviewRequest request = new PreviewRequest(_token, _account, _form);
            PreviewResponse response = request.SendRequestAsync().GetAwaiter().GetResult();

            Console.WriteLine("Order Preview Status {0}", response.Status);

        }

        public static void TestCreateOrder()
        {
            CreateOrderRequest request = new CreateOrderRequest(_token, _account, _form);
            OrderStatusResponse response = request.SendRequestAsync().GetAwaiter().GetResult();

            Console.WriteLine("Create Order Status {0}", response.Status);
        }

        public static void TestChangeOrder()
        {
            AccountOrdersRequest request = new AccountOrdersRequest(_token, _account);
            AccountOrdersResponse response = request.SendRequestAsync().GetAwaiter().GetResult();

            Order order = response.OrderDetails.Where(a => a.Symbol == "ON").Single();

            Console.WriteLine("Order {0} {1} {2}", order.Symbol, order.Quantity, order.Price);

            ChangeOrderRequest changeRequest = new ChangeOrderRequest(_token, _account, order);
            changeRequest.SetType(OrderType.limit);
            changeRequest.SetPrice(105.00m);

            OrderStatusResponse changeResponse = changeRequest.SendRequestAsync().GetAwaiter().GetResult();

            Console.WriteLine("Change Order Status {0}", changeResponse.Status);
        }

        public static void TestCancelOrder()
        {
            AccountOrdersRequest request = new AccountOrdersRequest(_token, _account);
            AccountOrdersResponse response = request.SendRequestAsync().GetAwaiter().GetResult();

            Order order = response.OrderDetails.Where(a => a.Symbol == "ON").Single();

            Console.WriteLine("Order {0} {1} {2}", order.Symbol, order.Quantity, order.Price);

            CancelOrderRequest cancelRequest = new CancelOrderRequest(_token, _account, order);
            OrderStatusResponse cancelResposne = cancelRequest.SendRequestAsync().GetAwaiter().GetResult();

            Console.WriteLine("Cancel Order Status {0}", cancelResposne.Status);
        }
    }
}
