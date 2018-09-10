namespace TradierClient.MarketData
{
    using System.Xml.Serialization;

    public class Security
    {
        [XmlElement("symbol")]
        public string Symbol { get; set; }

        [XmlElement("exchange")]
        public string Exchange { get; set; }

        [XmlElement("type")]
        public string _type { get; set; }

        [XmlIgnore]
        public SecurityType Type
        {
            get { return PropertyConverters.ParseEnum<SecurityType>(_type); }
        }

        [XmlElement("description")]
        public string Description { get; set; }
    }
}
