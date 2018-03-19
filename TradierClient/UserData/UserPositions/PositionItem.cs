namespace TradierClient.UserData
{
    using System;
    using System.Xml.Serialization;

    public class PositionItem
    {
        [XmlElement("cost_basis")]
        public decimal CostBasis { get; set; }

        [XmlElement("date_acquired")]
        public string _dateAcquired { get; set; }

        [XmlIgnore]
        public DateTime DateAcquired
        {
            get { return PropertyConverters.ParseDateTime(_dateAcquired, DateTimeFormats.DateHmsm); }
        }

        [XmlElement("id")]
        public int ID { get; set; }

        [XmlElement("quantity")]
        public decimal Quantity { get; set; }

        [XmlElement("symbol")]
        public string Symbol { get; set; }
    }
}
