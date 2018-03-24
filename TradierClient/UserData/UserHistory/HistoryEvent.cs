namespace TradierClient.UserData
{
    using System;
    using System.Xml.Serialization;
     
    public class HistoryEvent
    {
        [XmlElement("amount")]
        public decimal Amount { get; set; }

        [XmlElement("date")]
        public string _date { get; set; }

        [XmlIgnore]
        public DateTime Date
        {
            get { return PropertyConverters.ParseDateTime(_date, DateTimeFormats.DateHmsz); }
        }

        [XmlElement("type")]
        public string Type { get; set; }

        [XmlElement("trade")]
        public TradeDetails TradeDetails { get; set; }

        [XmlElement("adjustment")]
        public TradeDetails AdjustmentDetails { get; set; }
    }
}
