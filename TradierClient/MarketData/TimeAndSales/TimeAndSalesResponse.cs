namespace TradierClient.MarketData
{
    using System.Collections.Generic;
    using System.Xml.Serialization;

    [XmlRootAttribute("series")]
    public class TimeAndSalesResponse
    {
        [XmlElement("data")]
        public List<SaleData> Sales { get; set; }
    }
}
