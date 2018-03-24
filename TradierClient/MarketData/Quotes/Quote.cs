namespace TradierClient.MarketData
{
    using System.Xml.Serialization;

    public class Quote
    {
        [XmlElement("symbol")]
        public string Symbol { get; set; }

        [XmlElement("description")]
        public string Description { get; set; }

        [XmlElement("exch")]
        public string Exchange { get; set; }

        [XmlElement("type")]
        public string Type { get; set; }

        [XmlElement("last")]
        public string _last { get; set; }

        [XmlIgnore]
        public decimal? Last
        {
            get { return PropertyConverters.ParseDecimal(_last); }
        }

        [XmlElement("change")]
        public string _change { get; set; }

        [XmlIgnore]
        public decimal? Change
        {
            get { return PropertyConverters.ParseDecimal(_change); }
        }

        [XmlElement("change_percentage")]
        public string _changePercentage { get; set; }

        [XmlIgnore]
        public decimal? ChangePercentage
        {
            get { return PropertyConverters.ParseDecimal(_changePercentage); }
        }


        [XmlElement("volume")]
        public string _volume { get; set; }

        [XmlIgnore]
        public int? Volume
        {
            get { return PropertyConverters.ParseInt(_volume); }
        }

        [XmlElement("average_volume")]
        public string AverageVolume { get; set; }

        [XmlElement("last_volume")]
        public string LastVolume { get; set; }

        [XmlElement("trade_date")]
        public string TradeDate { get; set; }

        [XmlElement("open")]
        public string _open { get; set; }

        [XmlIgnore]
        public decimal? Open
        {
            get { return PropertyConverters.ParseDecimal(_open); }
        }

        [XmlElement("high")]
        public string _high { get; set; }

        [XmlIgnore]
        public decimal? High
        {
            get { return PropertyConverters.ParseDecimal(_high); }
        }

        [XmlElement("low")]
        public string _low { get; set; }

        [XmlIgnore]
        public decimal? Low
        {
            get { return PropertyConverters.ParseDecimal(_low); }
        }
        
        [XmlElement("close")]
        public string _close { get; set; }

        [XmlIgnore]
        public decimal? Close
        {
            get { return PropertyConverters.ParseDecimal(_close); }
        }

        [XmlElement("prevclose")]
        public string PrevClose { get; set; }

        [XmlElement("week_52_high")]
        public string Week52High { get; set; }

        [XmlElement("week_52_low")]
        public string Week52Low { get; set; }

        [XmlElement("bid")]
        public string _bid { get; set; }

        [XmlIgnore]
        public decimal? Bid
        {
            get { return PropertyConverters.ParseDecimal(_bid); }
        }

        [XmlElement("bidsize")]
        public string BidSize { get; set; }

        [XmlElement("bidexch")]
        public string BidExchange { get; set; }

        [XmlElement("bid_date")]
        public string BidDate { get; set; }

        [XmlElement("ask")]
        public string _ask { get; set; }

        [XmlIgnore]
        public decimal? Ask
        {
            get { return PropertyConverters.ParseDecimal(_ask); }
        }

        [XmlElement("asksize")]
        public string AskSize { get; set; }

        [XmlElement("askexch")]
        public string AskExchange { get; set; }

        [XmlElement("ask_date")]
        public string AskDate { get; set; }

        [XmlElement("open_interest")]
        public string OpenInterest { get; set; }

        [XmlElement("underlying")]
        public string UnderlyingSymbol { get; set; }

        [XmlElement("strike")]
        public string Strike { get; set; }

        [XmlElement("contract_size")]
        public string ContractSize { get; set; }

        [XmlElement("expiration_date")]
        public string ExpirationDate { get; set; }

        [XmlElement("expiration_type")]
        public string ExpirationType { get; set; }

        [XmlElement("option_type")]
        public string OptionType { get; set; }

    }
}
