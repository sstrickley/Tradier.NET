namespace TradierClient.UserData
{
    using System.Xml.Serialization;

    public class AccountOrders
    {
        [XmlElement("account_number")]
        public string AccountNumber { get; set; }

        [XmlElement("orders")]
        public Orders Orders { get; set; }
    }

}
