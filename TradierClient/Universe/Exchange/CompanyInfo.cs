namespace TradierClient.Universe
{
    using System;
    using System.Xml.Serialization;

    public class CompanyInfo
    {
        [XmlElement("Symbol")]
        public string Symbol { get; set; }

        [XmlElement("Name")]
        public string Name { get; set; }

        [XmlIgnore]
        public string Exchange { get; set; }

        [XmlElement("LastSale")]
        public string _lastSale { get; set; }
         
        [XmlIgnore]
        public double? LastSale
        {
            get { return PropertyConverters.ParseDouble(_lastSale); }
            set { _lastSale = value.ToString(); }
        }

        [XmlElement("MarketCap")]
        public string _marketCap { get; set; }

        [XmlIgnore]
        public double? MarketCap
        {
            get { return PropertyConverters.ParseDouble(_marketCap); }
            set { _marketCap = value.ToString(); }
        }

        [XmlElement("Sector")]
        public string Sector { get; set; }

        [XmlElement("Industry")]
        public string Industry { get; set; }

        public CompanyInfo()
        { }

        public void Create(string line)
        {
            var lineArray = line.Split(new string[] { "\",\"" }, StringSplitOptions.None);

            Symbol = lineArray[0].Replace("\"", "").Trim();
            Name = lineArray[1].Trim();
            _lastSale = lineArray[2].Trim();
            _marketCap = lineArray[3].Trim();
            Sector = lineArray[6].Trim();
            Industry = lineArray[7].Trim();
        }
    }
}
