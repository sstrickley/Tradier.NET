namespace TradierClient.MarketData
{
    using System.Xml.Serialization;

    public class Option
    {
        [XmlElement("symbol")]
        public string Symbol { get; set; }

        [XmlElement("strike")]
        public string _strike { get; set; }

        [XmlIgnore]
        public decimal? Strike
        {
            get { return PropertyConverters.ParseDecimal(_strike); }
        }

        [XmlElement("last")]
        public string _last { get; set; }

        [XmlIgnore]
        public decimal? Last
        {
            get { return PropertyConverters.ParseDecimal(_last); }
        }

        [XmlElement("bid")]
        public string _bid { get; set; }

        [XmlIgnore]
        public decimal? Bid
        {
            get { return PropertyConverters.ParseDecimal(_bid); }
        }

        [XmlElement("ask")]
        public string _ask { get; set; }

        [XmlIgnore]
        public decimal? Ask
        {
            get { return PropertyConverters.ParseDecimal(_ask); }
        }

        [XmlElement("change")]
        public string _change { get; set; }

        [XmlIgnore]
        public decimal? Change
        {
            get { return PropertyConverters.ParseDecimal(_change); }
        }

        [XmlElement("open_interest")]
        public string _openInterest { get; set; }

        [XmlIgnore]
        public decimal? OpenInterest
        {
            get { return PropertyConverters.ParseDecimal(_openInterest); }
        }
    }
}
