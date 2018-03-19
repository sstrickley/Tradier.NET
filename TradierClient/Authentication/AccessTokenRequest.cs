namespace TradierClient
{
    using System.IO;
    using System.Threading.Tasks;
    using System.Web.Script.Serialization;
    using TradierClient.Properties;

    public class AccessTokenRequest : IRequest<AccessToken>
    { 
        public AccessTokenRequest()
        { }

        public async Task<AccessToken> SendRequestAsync()
        {
            using (StreamReader reader = File.OpenText(Settings.Default.PathToToken))
            {
                string jsonText = await reader.ReadToEndAsync();
                return new JavaScriptSerializer().Deserialize<AccessToken>(jsonText);
            }
        }
    }
}
