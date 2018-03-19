namespace TradierClient.UserData
{
    using System.Collections.Generic;
    using System.Xml.Serialization;

    public class Orders
    {
        [XmlElement("order")]
        public List<Order> OrderDetails { get; set; }
    }
}
