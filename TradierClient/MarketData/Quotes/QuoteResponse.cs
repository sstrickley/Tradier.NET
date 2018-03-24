namespace TradierClient.MarketData
{
    using System.Collections.Generic;
    using System.Xml.Serialization;

    [XmlRootAttribute("quotes")]
    public class QuoteResponse
    {
        [XmlElement("quote")]
        public List<Quote> QuoteList { get; set; }
    }
}
