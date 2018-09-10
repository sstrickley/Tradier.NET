namespace TradierClient.MarketData
{ 
    using System;
    using System.Xml.Serialization;

    [XmlRootAttribute("data")]
    public class StreamData : EventArgs
    {
        [XmlElement("type")]
        public string Type { get; set; }

        [XmlElement("symbol")]
        public string Symbol { get; set; }

        [XmlElement("exch")]
        public string Exchange { get; set; }

        [XmlElement("price")]
        public string _price { get; set; }

        [XmlIgnore]
        public decimal? Price
        {
            get { return PropertyConverters.ParseDecimal(_price); }
        }

        [XmlElement("size")]
        public string _size { get; set; }

        [XmlIgnore]
        public int? Size
        {
            get { return PropertyConverters.ParseInt(_size); }
        }

        [XmlElement("colv")]
        public string _cumulativeVolume { get; set; }

        [XmlIgnore]
        public int? CumulativeVolume
        {
            get { return PropertyConverters.ParseInt(_cumulativeVolume); }
        }


        [XmlElement("date")]
        public string _date { get; set; }

        [XmlIgnore]
        public DateTime Date
        {
            get { return ParseUNIX(_date); }
        }

        private DateTime ParseUNIX(string val)
        {
            double output;

            if (!double.TryParse(val, out output))
                output = 0;

            return new DateTime(1970, 1, 1, 0, 0, 0)
                    .AddMilliseconds(output).ToLocalTime();
        }

        [XmlElement("bid")]
        public string _bid { get; set; }

        [XmlIgnore]
        public decimal? Bid
        {
            get { return PropertyConverters.ParseDecimal(_bid); }
        }

        [XmlElement("bidsz")]
        public string _bidsz { get; set; }

        [XmlIgnore]
        public int? BidSize
        {
            get { return PropertyConverters.ParseInt(_bidsz); }
        }

        [XmlElement("bidexch")]
        public string BidExchange { get; set; }

        [XmlElement("biddate")]
        public string _bidDate { get; set; }

        [XmlIgnore]
        public DateTime BidDate
        {
            get { return ParseUNIX(_bidDate); }
        }

        [XmlElement("ask")]
        public string _ask { get; set; }

        [XmlIgnore]
        public decimal? Ask
        {
            get { return PropertyConverters.ParseDecimal(_ask); }
        }

        [XmlElement("asksz")]
        public string _askSize { get; set; }

        [XmlIgnore]
        public int? AskSize
        {
            get { return PropertyConverters.ParseInt(_askSize); }
        }

        [XmlElement("askexch")]
        public string AskExchange { get; set; }

        [XmlElement("askdate")]
        public string _askDate { get; set; }

        [XmlIgnore]
        public DateTime AskDate
        {
            get { return ParseUNIX(_askDate); }
        }

        [XmlElement("open")]
        public string _open { get; set; }

        [XmlIgnore]
        public decimal? Open
        {
            get { return PropertyConverters.ParseDecimal(_open); }
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

        [XmlElement("prevClose")]
        public string _prevClose { get; set; }

        [XmlIgnore]
        public decimal? PreviousDayClose
        {
            get { return PropertyConverters.ParseDecimal(_prevClose); }
        }
    }
}
