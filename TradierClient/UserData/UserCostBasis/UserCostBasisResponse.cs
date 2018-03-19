namespace TradierClient.UserData
{
    using System.Collections.Generic;
    using System.Xml.Serialization;

    [XmlRootAttribute("accounts")]
    public class UserCostBasisResponse
    {
        [XmlElement("account")]
        public List<CostBasisAccount> CostBasisAccountDetails { get; set; }
    }
}
