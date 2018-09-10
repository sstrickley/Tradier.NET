namespace TradierClient.MarketData
{
    using System.Xml.Serialization;

    [XmlRootAttribute("stream")]
    public class SessionResponse
    {
        [XmlElement("sessionid")]
        public string SessionID { get; set; }

        [XmlElement("url")]
        public string URL { get; set; }
    }
}
