namespace TradierClient.UserData
{
    using System.Collections.Generic;
    using System.Xml.Serialization;

    [XmlRootAttribute("profile")]
    public class ProfileResponse
    {
        [XmlElement("id")]
        public string Id { get; set; }

        [XmlElement("account")]
        public List<Account> Accounts { get; set; }

        [XmlElement("name")]
        public string Name { get; set; }
    }
}
