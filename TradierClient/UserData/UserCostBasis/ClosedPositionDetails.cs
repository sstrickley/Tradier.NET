namespace TradierClient.UserData
{
    using System;
    using System.Xml.Serialization;

    public class ClosedPositionDetails
    {
        [XmlElement("close_date")]
        public string _closeDate { get; set; }

        [XmlIgnore]
        public DateTime CloseDate
        {
            get { return PropertyConverters.ParseDateTime(_closeDate, DateTimeFormats.DateHmsmz); }
        }

        [XmlElement("cost")]
        public string _cost { get; set; }

        [XmlIgnore]
        public decimal? Cost
        {
            get { return PropertyConverters.ParseDecimal(_cost); }
        }

        [XmlElement("gain_loss")]
        public string _gainLoss { get; set; }

        [XmlIgnore]
        public decimal? GainLoss
        {
            get { return PropertyConverters.ParseDecimal(_gainLoss); }
        }

        [XmlElement("gain_loss_percent")]
        public string _gainLossPercent { get; set; }

        [XmlIgnore]
        public decimal? GainLossPercent
        {
            get { return PropertyConverters.ParseDecimal(_gainLossPercent); }
        }

        [XmlElement("open_date")]
        public string _openDate { get; set; }

        [XmlIgnore]
        public DateTime OpenDate
        {
            get { return PropertyConverters.ParseDateTime(_openDate, DateTimeFormats.DateHmsmz); }
        }

        [XmlElement("proceeds")]
        public string _proceeds { get; set; }

        [XmlIgnore]
        public decimal? Proceeds
        {
            get { return PropertyConverters.ParseDecimal(_proceeds); }
        }

        [XmlElement("quantity")]
        public string _quantity { get; set; }

        [XmlIgnore]
        public decimal? Quantity
        {
            get { return PropertyConverters.ParseDecimal(_quantity); }
        }

        [XmlElement("symbol")]
        public string Symbol { get; set; }

        [XmlElement("term")]
        public string _term { get; set; }

        [XmlIgnore]
        public int? Term
        {
            get { return PropertyConverters.ParseInt(_term); }
        }
    }
}
