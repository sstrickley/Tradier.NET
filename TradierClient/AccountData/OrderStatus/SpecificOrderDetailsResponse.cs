namespace TradierClient.AccountData
{
    using System.Xml.Serialization;
    using TradierClient.UserData;

    [XmlRootAttribute("order")]
    public class SpecificOrderDetailsResponse : Order
    { }
}
