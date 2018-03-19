namespace TradierClient.UserData
{
    using System.Xml.Serialization;

    public class TradeDetails
    {
        [XmlElement("commission")]
        public string _commission { get; set; }

        [XmlIgnore]
        public decimal? Commission
        {
            get { return PropertyConverters.ParseDecimal(_commission); }
        }

        [XmlElement("description")]
        public string Description { get; set; }

        [XmlElement("price")]
        public string _price { get; set; }
        
        [XmlIgnore]
        public decimal? Price
        {
            get { return PropertyConverters.ParseDecimal(_price); }
        }

        [XmlElement("quantity")]
        public string _quantity { get; set; }

        [XmlIgnore]
        public decimal? Quantity
        {
            get { return PropertyConverters.ParseDecimal(_quantity); }
        }

        [XmlElement("symbol")]
        public string Symbol { get; set; }

        [XmlElement("trade_type")]
        public string TradeType { get; set; }
    }
}
