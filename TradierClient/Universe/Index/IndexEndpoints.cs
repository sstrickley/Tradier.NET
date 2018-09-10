namespace TradierClient.Universe
{
    public class IndexEndpoints
    {
        public static readonly string SP500_Endpoint = "https://en.wikipedia.org/wiki/List_of_S%26P_500_companies";
        public static readonly string SP400_Endpoint = "https://en.wikipedia.org/wiki/List_of_S%26P_400_companies";

        public static string GetEndpoint(Index idx)
        {
            switch(idx)
            {
                case Index.SP400:
                    return SP400_Endpoint;

                case Index.SP500:
                    return SP500_Endpoint;

                default:
                    return string.Empty;
            }
        }
    }
}
