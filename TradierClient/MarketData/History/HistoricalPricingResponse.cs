namespace TradierClient.MarketData
{
    using System.Collections.Generic;
    using System.Xml.Serialization;

    [XmlRootAttribute("history")]
    public class HistoricalPricingResponse
    {
        [XmlElement("day")]
        public List<DailyPriceData> Days { get; set; }

        public HistoricalPricingResponse()
        {
            Days = new List<DailyPriceData>();
        }
    }
}
