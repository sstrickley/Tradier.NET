namespace TradierClient.MarketData
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Xml.Serialization;

    [XmlRootAttribute("expirations")]
    public class OptionExpireResponse
    {
        [XmlElement("date")]
        public List<string> _expirationDates { get; set; }

        private List<DateTime> _expireDates;

        [XmlIgnore]
        public List<DateTime> ExpirationDates
        {
            get
            {
                if (_expireDates.Count == 0)
                    _expireDates = _expirationDates
                        .Select(a => PropertyConverters.ParseDateTime(a, DateTimeFormats.DateYmd))
                        .ToList();

                return _expireDates;
            }
        }

        public OptionExpireResponse()
        {
            _expireDates = new List<DateTime>();
        }
    }
}
