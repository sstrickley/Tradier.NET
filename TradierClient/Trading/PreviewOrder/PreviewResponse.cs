namespace TradierClient.Trading
{
    using System.Xml.Serialization;

    [XmlRootAttribute("order")]
    public class PreviewResponse
    {
        [XmlElement("commission")]
        public decimal Commission { get; set; }

        [XmlElement("cost")]
        public decimal Cost { get; set; }

        [XmlElement("extended_hours")]
        public string _extendedHours { get; set; }

        [XmlIgnore]
        public bool ExtendedHours
        {
            get { return bool.Parse(_extendedHours); }
        }

        [XmlElement("fees")]
        public decimal Fees { get; set; }

        [XmlElement("margin_change")]
        public decimal MarginChange { get; set; }

        [XmlElement("quantity")]
        public decimal Quantity { get; set; }

        [XmlElement("status")]
        public string Status { get; set; }
    }
}
