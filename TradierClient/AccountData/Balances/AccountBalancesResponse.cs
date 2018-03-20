namespace TradierClient.AccountData
{
    using System.Xml.Serialization;
    using TradierClient.UserData;

    [XmlRootAttribute("balances")]
    public class AccountBalancesResponse : Balance
    { }
}
