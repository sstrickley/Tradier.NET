namespace TradierClient.MarketData
{
    using System.Xml.Serialization;

    public class OptionStrike
    {
        [XmlElement("strike")]
        public string _strike { get; set; }

        [XmlIgnore]
        public decimal? Strike
        {
            get { return PropertyConverters.ParseDecimal(_strike); }
        }
    }
}
