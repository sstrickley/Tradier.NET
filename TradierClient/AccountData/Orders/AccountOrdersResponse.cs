namespace TradierClient.AccountData
{
    using System.Xml.Serialization;
    using TradierClient.UserData;

    [XmlRootAttribute("orders")]
    public class AccountOrdersResponse : Orders
    { }
}
