namespace TradierClient.UserData
{
    using System.Xml.Serialization;

    public class CostBasisAccount
    {
        [XmlElement("account_number")]
        public string AccountNumber { get; set; }

        [XmlElement("gainloss")]
        public GainLoss GainLossDetails { get; set; }
    }
}
