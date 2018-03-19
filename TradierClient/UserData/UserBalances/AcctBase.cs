namespace TradierClient.UserData
{
    using System.Xml.Serialization;

    public abstract class AcctBase
    {
        [XmlElement("fed_call")]
        public string _fedClall { get; set; }

        [XmlIgnore]
        public decimal? FedCall
        {
            get { return PropertyConverters.ParseDecimal(_fedClall); }
        }

        [XmlElement("maintenance_call")]
        public string _maintCall { get; set; }

        [XmlIgnore]
        public decimal? MaintenanceCall
        {
            get { return PropertyConverters.ParseDecimal(_maintCall); }
        }

        [XmlElement("option_buying_power")]
        public string _optionBuyingPower { get; set; }

        [XmlIgnore]
        public decimal? OptionBuyingPower
        {
            get { return PropertyConverters.ParseDecimal(_optionBuyingPower); }
        }

        [XmlElement("stock_buying_power")]
        public string _stockBuyingPower { get; set; }

        [XmlIgnore]
        public decimal? StockBuyingPower
        {
            get { return PropertyConverters.ParseDecimal(_stockBuyingPower); }
        }

        [XmlElement("short_stock_value")]
        public string _shortStockValue { get; set; }

        [XmlIgnore]
        public decimal? ShortStockValue
        {
            get { return PropertyConverters.ParseDecimal(_shortStockValue); }
        }
    }
}
