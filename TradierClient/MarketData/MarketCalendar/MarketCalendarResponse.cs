namespace TradierClient.MarketData
{
    using System.Collections.Generic;
    using System.Xml.Serialization;

    [XmlRootAttribute("calendar")]
    public class MarketCalendarResponse
    {
        [XmlArray("days")]
        [XmlArrayItem("day")]
        public List<MarketDay> Days { get; set; }

        [XmlElement("month")]
        public string _month { get; set; }

        [XmlIgnore]
        public int? Month
        {
            get { return PropertyConverters.ParseInt(_month); }
        }

        [XmlElement("year")]
        public string _year { get; set; }

        [XmlIgnore]
        public int? Year
        {
            get { return PropertyConverters.ParseInt(_year); }
        }
    }
}
