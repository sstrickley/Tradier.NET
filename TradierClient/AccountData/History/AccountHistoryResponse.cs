namespace TradierClient.AccountData
{
    using System.Xml.Serialization;
    using TradierClient.UserData;

    [XmlRootAttribute("history")]
    public class AccountHistoryResponse : History
    { }
}
