namespace TradierClient.MarketData
{
    using System.Collections.Generic;
    using System.Xml.Serialization;

    [XmlRootAttribute("options")]
    public class OptionChainResponse
    {
        [XmlElement("option")]
        public List<Option> Options { get; set; }
    }
}
