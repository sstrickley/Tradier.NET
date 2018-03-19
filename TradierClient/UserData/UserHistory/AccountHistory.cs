namespace TradierClient.UserData
{
    using System.Xml.Serialization;

    public class AccountHistory
    {
        [XmlElement("account_number")]
        public string AccountNumber { get; set; }

        [XmlElement("transactions")]
        public History History { get; set; }
    }
}
