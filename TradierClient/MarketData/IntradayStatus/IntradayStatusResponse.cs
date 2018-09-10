namespace TradierClient.MarketData
{
    using System;
    using System.Xml.Serialization;

    [XmlRootAttribute("clock")]
    public class IntradayStatusResponse
    {
        [XmlElement("date")]
        public string _date { get; set; }

        [XmlIgnore]
        public DateTime Date
        {
            get { return PropertyConverters.ParseDateTime(_date, DateTimeFormats.DateYmd); }
        }

        [XmlElement("description")]
        public string Description { get; set; }

        [XmlElement("next_change")]
        public string _nextChange { get; set; }

        [XmlIgnore]
        public DateTime NextChange
        {
            get
            {
                DateTime output = PropertyConverters.ParseDateTime(
                    string.Format("{0}T{1}", _date, _nextChange),
                    DateTimeFormats.DateHm
                );

                // Check if next status is tommorrow and add 
                // a day if it is.
                if (output < DateTime.Today)
                    output.AddDays(1);

                return output;
            }
        }

        [XmlElement("next_state")]
        public string NextState { get; set; }

        [XmlElement("state")]
        public string CurrentState { get; set; }

        [XmlElement("timestamp")]
        public string _timestamp { get; set; }

        [XmlIgnore]
        public DateTime? Timestamp
        {
            get { return PropertyConverters.ParseUnixTimeSec(_timestamp).Value.ToLocalTime(); }
        }
    }
}
