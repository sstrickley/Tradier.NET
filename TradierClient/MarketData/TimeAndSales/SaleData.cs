namespace TradierClient.MarketData
{
    using System;
    using System.Xml.Serialization;

    public class SaleData
    {
        [XmlElement("time")]
        public string _time { get; set; }

        [XmlIgnore]
        public DateTime Time
        {
            get { return PropertyConverters.ParseDateTime(_time, DateTimeFormats.DateHms); }
        }

        [XmlElement("open")]
        public string _open { get; set; }

        [XmlIgnore]
        public decimal? Open
        {
            get { return PropertyConverters.ParseDecimal(_open); }
        }

        [XmlElement("close")]
        public string _close { get; set; }

        [XmlIgnore]
        public decimal? Close
        {
            get { return PropertyConverters.ParseDecimal(_close); }
        }

        [XmlElement("high")]
        public string _high { get; set; }

        [XmlIgnore]
        public decimal? High
        {
            get { return PropertyConverters.ParseDecimal(_high); }
        }

        [XmlElement("volume")]
        public string _volume { get; set; }

        [XmlIgnore]
        public int? Volume
        {
            get { return PropertyConverters.ParseInt(_volume); }
        }
    }
}
