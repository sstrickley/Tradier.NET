namespace TradierClient.UserData
{
    using System.Xml.Serialization;

    public class UserBalances
    {
        [XmlElement("balances")]
        public Balance AccountBalances { get; set; }
    }
}
