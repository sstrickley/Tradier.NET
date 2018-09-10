namespace TradierClient.Universe
{
    using System;
    using System.Collections.Generic;
    using System.Xml.Serialization;

    [XmlRoot("Exchange")]
    public class ExchangeResponse
    {
        [XmlElement("Date")]
        public string _date { get; set; }

        [XmlIgnore]
        public DateTime Date
        {
            get { return PropertyConverters.ParseDateTime(_date, DateTimeFormats.DateYmd); }
            set { _date = value.ToString(DateTimeFormats.DateYmd); }
        }

        [XmlElement("Companies")]
        public List<CompanyInfo> Companies { get; set; }

        public ExchangeResponse()
        {
            Companies = new List<CompanyInfo>();
        }

    }
}
