namespace TradierClient.MarketData
{
    using System.Collections.Generic;

    public class QuoteRequest : GetRequest<QuoteResponse>
    {
        private QuoteRequest(AccessToken token) : base(token, Endpoints.Request)
        { }

        public QuoteRequest(AccessToken token, string symbol) : this(token)
        {
            SetPath("markets/quotes?symbols={0}", symbol);
        }


        public QuoteRequest(AccessToken token, List<string> symbols) : this(token)
        {
            SetPath("markets/quotes?symbols={0}", string.Join(",", symbols));
        }
    }
}
