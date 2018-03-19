using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using TradierClient.UserData;

namespace TradierClient.AccountData
{
    [XmlRootAttribute("balances")]
    public class AccountBalancesResponse : Balance
    {

    }
}
