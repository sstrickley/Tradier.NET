namespace TradierClient.MarketData
{
    using System.Collections.Generic;
    using System.Xml.Serialization;

    [XmlRootAttribute("securities")]
    public class CompanySearchResponse
    {
        [XmlElement("security")]
        public List<Security> Results { get; set; }
    }
}
