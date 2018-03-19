using System.Xml.Serialization;

namespace TradierClient.UserData
{
    public class Margin
    {
        [XmlElement("sweep")]
        public string _sweep { get; set; }

        [XmlIgnore]
        public decimal? Sweep
        {
            get { return PropertyConverters.ParseDecimal(_sweep); }
        }
    }
}
