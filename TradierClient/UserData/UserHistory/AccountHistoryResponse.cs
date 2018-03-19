namespace TradierClient.UserData
{
    using System.Collections.Generic;
    using System.Xml.Serialization;

    [XmlRootAttribute("accounts")]
    public class AccountHistoryResponse
    {
        [XmlElement("account")]
        public List<AccountHistory> AccountHistory { get; set; }
    }
}
