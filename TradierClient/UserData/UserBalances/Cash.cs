namespace TradierClient.UserData
{
    using System.Xml.Serialization;

    public class Cash
    {
        [XmlElement("cash_available")]
        public decimal CashAvailable { get; set; }

        [XmlElement("sweep")]
        public decimal Sweep { get; set; }

        [XmlElement("unsettled_funds")]
        public decimal UnsettledFunds { get; set; }
    }
}
