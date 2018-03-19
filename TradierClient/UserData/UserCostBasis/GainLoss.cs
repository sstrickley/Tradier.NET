namespace TradierClient.UserData
{
    using System.Collections.Generic;
    using System.Xml.Serialization;

    public class GainLoss
    {
        [XmlElement("closed_position")]
        public List<ClosedPositionDetails> ClosedPositions { get; set; }
    }
}
