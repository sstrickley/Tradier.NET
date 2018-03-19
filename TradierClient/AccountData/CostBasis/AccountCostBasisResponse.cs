namespace TradierClient.AccountData
{
    using System.Xml.Serialization;
    using TradierClient.UserData;

    [XmlRootAttribute("gainloss")]
    public class AccountCostBasisResponse : GainLoss
    { }
}
