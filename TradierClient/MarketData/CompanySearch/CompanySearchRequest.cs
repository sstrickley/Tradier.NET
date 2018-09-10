namespace TradierClient.MarketData
{
    using System.Threading.Tasks;

    public class CompanySearchRequest : GetRequest<CompanySearchResponse>
    {
        public CompanySearchRequest(AccessToken token, string keyword) : base(token, Endpoints.Request)
        {
            Parameters.Add("q", keyword);
        }

        public void IncludeIndexes()
        {
            Parameters.Add("indexes", "true");
        }

        public override async Task<CompanySearchResponse> SendRequestAsync()
        {
            SetPath("markets/search?{0}", GetFormatedParams());

            return await base.SendRequestAsync();
        }
    }
}
