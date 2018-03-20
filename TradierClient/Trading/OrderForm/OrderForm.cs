namespace TradierClient.Trading
{
    using System.Collections.Generic;

    public class OrderForm : IOrderForm
    {

        public OrderClass? Class { get; set; }

        public string Symbol { get; set; }

        public OrderDuration? Duration { get; set; }

        public OrderSide? Side { get; set; }

        public int Quantity { get; set; }

        public OrderType? Type { get; set; }

        public decimal Price { get; set; }

        public decimal Stop { get; set; }

        public string OptionSymbol { get; set; }

        public OrderForm()
        { }

        private OrderForm(string symbol, int quantity, decimal price)
        {
            Symbol = symbol;
            Quantity = quantity;
            Price = price;
        }

        public static IOrderForm CreateBuyLimitOrder(string symbol, int quantity, decimal price)
        {
            OrderForm form = new OrderForm(symbol, quantity, price);
            form.CreateLimitOrder();
            form.Side = OrderSide.buy;

            return form;
        }

        private void CreateLimitOrder()
        {
            Class = OrderClass.equity; 
            Duration = OrderDuration.day;
            Type = OrderType.limit;
        }

        public static IOrderForm CreateSellLimitOrder(string symbol, int quantity, decimal price)
        {
            OrderForm form = new OrderForm(symbol, quantity, price);
            form.CreateLimitOrder();
            form.Side = OrderSide.sell;

            return form;
        }

        public bool IsValid()
        {
            bool isValid = Class != null &&
                Symbol.Length > 0 &&
                Symbol.Length < 10 &&
                Duration != null &&
                Side != null &&
                Quantity > 0 &&
                Type != null;

            if (Type == OrderType.limit || Type == OrderType.stop_limit)
                isValid = isValid && Price > 0;

            if (Type == OrderType.stop || Type == OrderType.stop_limit)
                isValid = isValid && Stop > 0;

            if (Class == OrderClass.option)
                isValid = isValid && OptionSymbol.Length > 0;

            return isValid;
        }

        public Dictionary<string, string> GetPostParameters()
        {
            Dictionary<string, string> postParams = new Dictionary<string, string>();
            postParams.Add("class", Class.ToString());
            postParams.Add("symbol", Symbol);
            postParams.Add("duration", Duration.ToString());
            postParams.Add("side", Side.ToString());
            postParams.Add("quantity", Quantity.ToString());
            postParams.Add("type", Type.ToString());

            if (Type == OrderType.limit || Type == OrderType.stop_limit)
                postParams.Add("price", Price.ToString());

            if (Type == OrderType.stop || Type == OrderType.stop_limit)
                postParams.Add("stop", Stop.ToString());

            if (Class == OrderClass.option)
                postParams.Add("option_symbol", OptionSymbol);

            return postParams;
        }
    }
}
