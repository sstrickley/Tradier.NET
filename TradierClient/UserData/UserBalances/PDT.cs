namespace TradierClient.UserData
{
    using System.Xml.Serialization;

    public class PDT : AcctBase
    {
        [XmlElement("day_trade_buying_power")]
        public decimal DayTradeBuyingPower { get; set; }
    }
}
