namespace TradierClient.UserData
{
    using System.Collections.Generic;
    using System.Xml.Serialization;

    public class PositionsArray
    {
        [XmlElement("position")]
        public List<PositionItem> PositionList { get; set; }
    }
}
