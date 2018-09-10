namespace TradierClient.MarketData
{
    using System.Xml.Serialization;

    public class MarketHours
    {
        [XmlElement("start")]
        public string Start { get; set; }

        [XmlElement("end")]
        public string End { get; set; }
    }
}
