namespace TradierClient.MarketData
{
    using System;
    using System.Xml.Serialization;

    public class MarketDay
    {
        [XmlElement("date")]
        public string _date { get; set; }

        [XmlIgnore]
        public DateTime Date
        {
            get { return PropertyConverters.ParseDateTime(_date, DateTimeFormats.DateYmd); }
        }

        [XmlElement("status")]
        public string _status { get; set; }

        [XmlIgnore]
        public MarketStatus Status
        {
            get { return PropertyConverters.ParseEnum<MarketStatus>(_status); }
        }

        [XmlElement("description")]
        public string Description { get; set; }

        [XmlElement("premarket")]
        public MarketHours PreMarket { get; set; }

        [XmlElement("open")]
        public MarketHours RegularHours { get; set; }

        [XmlElement("postmarket")]
        public MarketHours PostMarket { get; set; }

        [XmlIgnore]
        public DateTime PreMarketStart
        {
            get
            {
                return PropertyConverters.ParseDateTime(
                    string.Format("{0}T{1}", _date, PreMarket.Start),
                    DateTimeFormats.DateHm
                );
            }
        }

        [XmlIgnore]
        public DateTime PreMarketClose
        {
            get { return PropertyConverters.ParseDateTime(
                    string.Format("{0}T{1}", _date, PreMarket.End),
                    DateTimeFormats.DateHm
                );
            }
        }

        [XmlIgnore]
        public DateTime MarketOpen
        {
            get { return PropertyConverters.ParseDateTime(
                    string.Format("{0}T{1}", _date, RegularHours.Start),
                    DateTimeFormats.DateHm
                );
            }
        }

        [XmlIgnore]
        public DateTime MarketClose
        {
            get { return PropertyConverters.ParseDateTime(
                    string.Format("{0}T{1}", _date, RegularHours.End),
                    DateTimeFormats.DateHm
                );
            }
        }

        [XmlIgnore]
        public DateTime PostMarketStart
        {
            get { return PropertyConverters.ParseDateTime(
                    string.Format("{0}T{1}", _date, PostMarket.Start),
                    DateTimeFormats.DateHm
                );
            }
        }

        [XmlIgnore]
        public DateTime PostMarketEnd
        {
            get { return PropertyConverters.ParseDateTime(
                    string.Format("{0}T{1}", _date, PostMarket.End),
                    DateTimeFormats.DateHm
                );
            }
        }
    }
}
