namespace TradierClient.UserData
{
    using System;
    using System.Xml.Serialization;

    public class Order
    {
        [XmlElement("id")]
        public string Id { get; set; }

        [XmlElement("type")]
        public string Type { get; set; }

        [XmlElement("symbol")]
        public string Symbol { get; set; }

        [XmlElement("side")]
        public string Side { get; set; }

        [XmlElement("quantity")]
        public string _quantity { get; set; }

        [XmlIgnore]
        public decimal? Quantity
        {
            get { return PropertyConverters.ParseDecimal(_quantity); }
        }

        [XmlElement("status")]
        public string Status { get; set; }

        [XmlElement("duration")]
        public string Duration { get; set; }

        [XmlElement("price")]
        public string _price { get; set; }

        [XmlIgnore]
        public decimal? Price
        {
            get { return PropertyConverters.ParseDecimal(_price); }
        }

        [XmlElement("avg_fill_price")]
        public string _avgFillPrice { get; set; }

        [XmlIgnore]
        public decimal? AverageFillPrice
        {
            get { return PropertyConverters.ParseDecimal(_avgFillPrice); }
        }

        [XmlElement("exec_quantity")]
        public string _execQuantity { get; set; }

        [XmlIgnore]
        public decimal? ExecutedQuantity
        {
            get { return PropertyConverters.ParseDecimal(_execQuantity); }
        }

        [XmlElement("last_fill_price")]
        public string _lastFillPrice { get; set; }

        [XmlIgnore]
        public decimal? LastFillPrice
        {
            get { return PropertyConverters.ParseDecimal(_lastFillPrice); }
        }

        [XmlElement("last_fill_quantity")]
        public string _lastFillQuantity { get; set; }

        [XmlIgnore]
        public decimal? LastFillQuantity
        {
            get { return PropertyConverters.ParseDecimal(_lastFillQuantity); }
        }

        [XmlElement("remaining_quantity")]
        public string _remainingQuantity { get; set; }

        [XmlIgnore]
        public decimal? RemainingQuantity
        {
            get { return PropertyConverters.ParseDecimal(_remainingQuantity); }
        }

        [XmlElement("create_date")]
        public string _createDate { get; set; }

        [XmlIgnore]
        public DateTime? CreateDate
        {
            get { return PropertyConverters.ParseDateTime(_createDate, DateTimeFormats.DateHmsm); }
        }

        [XmlElement("transaction_date")]
        public string _transDate { get; set; }

        [XmlIgnore]
        public DateTime? TransactionDate
        {
            get { return PropertyConverters.ParseDateTime(_transDate, DateTimeFormats.DateHmsm); }
        }

        [XmlElement("class")]
        public string Class { get; set; }
    }
}
