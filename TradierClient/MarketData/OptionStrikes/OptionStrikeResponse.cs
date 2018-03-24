namespace TradierClient.MarketData
{
    using System.Xml.Serialization;
    using System.Collections.Generic;

    [XmlRootAttribute("strikes")]
    public class OptionStrikeResponse
    {
        [XmlElement("strike")]
        public List<decimal?> OptionStrikes { get; set; }
    }
}
