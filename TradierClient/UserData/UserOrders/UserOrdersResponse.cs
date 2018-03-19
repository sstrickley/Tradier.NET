namespace TradierClient.UserData
{
    using System.Collections.Generic;
    using System.Xml.Serialization;
    
    [XmlRootAttribute("accounts")]
    public class UserOrdersResponse
    {
        [XmlElement("account")]
        public List<AccountOrders> Accounts { get; set; }
    }
}
