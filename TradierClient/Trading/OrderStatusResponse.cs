namespace TradierClient.Trading
{
    using System.Xml.Serialization;

    [XmlRootAttribute("order")]
    public class OrderStatusResponse
    {
        [XmlElement("id")]
        public int OrderID { get; set; }

        [XmlElement("status")]
        public string Status { get; set; }
    }
}
