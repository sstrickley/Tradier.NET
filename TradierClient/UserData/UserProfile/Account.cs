namespace TradierClient
{
    using System;
    using System.Xml.Serialization;

    public class Account
    {
        [XmlElement("account_number")]
        public string AccountNumber { get; set; }

        [XmlElement("classification")]
        public string Classification { get; set; }

        [XmlElement("day_trader")]
        public string _dayTrader { get; set; }

        [XmlIgnore]
        public bool IsDayTrader
        {
            get { return PropertyConverters.ParseBool(_dayTrader); }
        }

        [XmlElement("option_level")]
        public int OptionsLevel { get; set; }

        [XmlElement("status")]
        public string Status { get; set; }

        [XmlElement("type")]
        public string Type { get; set; }

        [XmlElement("last_update_date")]
        public string _lastUpdateDate { get; set; }

        [XmlIgnore]
        public DateTime LastUpdateDate
        {
            get { return PropertyConverters.ParseDateTime(_lastUpdateDate, DateTimeFormats.DateHmsm); }
        }

    }
}
