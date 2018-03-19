namespace TradierClient.UserData
{
    using System.Collections.Generic;
    using System.Xml.Serialization;

    [XmlRootAttribute("accounts")]
    public class BalancesResponse
    {
        [XmlElement("account")]
        public List<UserBalances> accounts { get; set; }
    }
}
