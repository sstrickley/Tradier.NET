namespace TradierClient.UserData
{
    using System.Collections.Generic;
    using System.Xml.Serialization;

    [XmlRootAttribute("accounts")]
    public class PositionResponse
    {
        [XmlElement("account")]
        public List<AccountPositions> Accounts { get; set; }
    }
}

