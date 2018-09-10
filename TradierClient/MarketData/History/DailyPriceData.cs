namespace TradierClient.MarketData
{
    using System;
    using System.Xml.Serialization;

    public class DailyPriceData
    {
        [XmlIgnore]
        public int Id { get; set; }

        [XmlElement("date")]
        public string _date { get; set; }

        [XmlIgnore]
        public DateTime Date
        {
            get { return PropertyConverters.ParseDateTime(_date, DateTimeFormats.DateYmd); }
            set { _date = value.ToString(DateTimeFormats.DateYmd); }
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

        [XmlElement("low")]
        public string _low { get; set; }

        [XmlIgnore]
        public decimal? Low
        {
            get { return PropertyConverters.ParseDecimal(_low); }
        }

        [XmlElement("volume")]
        public string _volume { get; set; }

        public int? Volume
        {
            get { return PropertyConverters.ParseInt(_volume); }
        }
        
    }
}
