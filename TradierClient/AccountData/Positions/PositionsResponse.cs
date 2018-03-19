namespace TradierClient.AccountData
{
    using System.Xml.Serialization;
    using TradierClient.UserData;

    [XmlRootAttribute("positions")]
    public class PositionsResponse : PositionsArray
    { }
}
