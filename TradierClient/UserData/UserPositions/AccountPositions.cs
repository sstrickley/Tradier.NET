namespace TradierClient.UserData
{
    using System.Xml.Serialization;

    public class AccountPositions
    {
        [XmlElement("account_number")]
        public string AccountNumber { get; set; }

        [XmlElement("positions")]
        public PositionsArray Positions { get; set; }
    }
}
