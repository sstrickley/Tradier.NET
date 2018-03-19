namespace TradierClient.UserData
{
    using System.Collections.Generic;
    using System.Xml.Serialization;

    public class History
    {
        [XmlElement("event")]
        public List<HistoryEvent> Events { get; set; }
    }
}
