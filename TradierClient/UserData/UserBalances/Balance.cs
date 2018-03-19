using System.Xml.Serialization;

namespace TradierClient.UserData
{
    public class Balance
    {
        [XmlElement("account_number")]
        public string AccountNumber { get; set; }

        [XmlElement("account_type")]
        public string AccountType { get; set; }

        [XmlElement("close_pl")]
        public string _closePL { get; set; }

        [XmlIgnore]
        public decimal? CloseProfitLoss
        {
            get { return PropertyConverters.ParseDecimal(_closePL); }
        }

        [XmlElement("current_requirement")]
        public string _currentRequirement { get; set; }

        [XmlIgnore]
        public decimal? CurrentRequirement
        {
            get { return PropertyConverters.ParseDecimal(_currentRequirement); }
        }

        [XmlElement("equity")]
        public string _equity { get; set; }

        [XmlIgnore]
        public decimal? Equity
        {
            get { return PropertyConverters.ParseDecimal(_equity); }
        }

        [XmlElement("long_market_value")]
        public string _longMarketValue { get; set; }

        [XmlIgnore]
        public decimal? LongMarketValue
        {
            get { return PropertyConverters.ParseDecimal(_longMarketValue); }
        }

        [XmlElement("market_value")]
        public string _marketValue { get; set; }

        [XmlIgnore]
        public decimal? MarketValue
        {
            get { return PropertyConverters.ParseDecimal(_marketValue); }
        }

        [XmlElement("open_pl")]
        public string _openPL { get; set; }

        [XmlIgnore]
        public decimal? OpenProfitLoss
        {
            get { return PropertyConverters.ParseDecimal(_openPL); }
        }

        [XmlElement("option_long_value")]
        public string _optionLongValue { get; set; }

        [XmlIgnore]
        public decimal? OptionLongValue
        {
            get { return PropertyConverters.ParseDecimal(_optionLongValue); }
        }

        [XmlElement("option_requirement")]
        public string _optionRequirement { get; set; }

        [XmlIgnore]
        public decimal? OptionRequirement
        {
            get { return PropertyConverters.ParseDecimal(_optionRequirement); }
        }

        [XmlElement("option_short_value")]
        public string _optionShortValue { get; set; }

        [XmlIgnore]
        public decimal? OptionShortValue
        {
            get { return PropertyConverters.ParseDecimal(_optionRequirement); }
        }

        [XmlElement("pending_orders_count")]
        public string _pendingOrdersCount { get; set; }

        [XmlIgnore]
        public int? PendingOrdersCount
        {
            get { return PropertyConverters.ParseInt(_pendingOrdersCount); }
        }

        [XmlElement("short_market_value")]
        public string _shortMarketValue { get; set; }

        [XmlIgnore]
        public decimal? ShortMarketValue
        {
            get { return PropertyConverters.ParseDecimal(_shortMarketValue); }
        }

        [XmlElement("stock_long_value")]
        public string _stockLongValue { get; set; }

        [XmlIgnore]
        public decimal? StockLongValue
        {
            get { return PropertyConverters.ParseDecimal(_stockLongValue); }
        }

        [XmlElement("total_cash")]
        public string _totalCash { get; set; }

        [XmlIgnore]
        public decimal? TotalCash
        {
            get { return PropertyConverters.ParseDecimal(_totalCash); }
        }

        [XmlElement("total_equity")]
        public string _totalEquity { get; set; }

        [XmlIgnore]
        public decimal? TotalEquity
        {
            get { return PropertyConverters.ParseDecimal(_totalEquity); }
        }

        [XmlElement("uncleared_funds")]
        public string _unclearedFunds { get; set; }

        [XmlIgnore]
        public decimal? UnclearedFunds
        {
            get { return PropertyConverters.ParseDecimal(_unclearedFunds); }
        }

        [XmlElement("margin")]
        public Margin MarginDetails { get; set; }

        [XmlElement("cash")]
        public Cash CashDetails { get; set; }

        [XmlElement("pdt")]
        public PDT DayTradeDetails { get; set; }
    }
}
