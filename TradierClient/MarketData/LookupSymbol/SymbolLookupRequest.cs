namespace TradierClient.MarketData
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public class SymbolLookupRequest : GetRequest<CompanySearchResponse>
    {
        public List<string> _codes;
        public List<string> _types;

        public SymbolLookupRequest(AccessToken token) : base(token, Endpoints.Request)
        {
            _codes = new List<string>();
            _types = new List<string>();
        }

        public void SetSearchKeyword(string keyword)
        {
            Parameters.Add("q", keyword);
        }

        public void SetExchangeCode(string code)
        {
            _codes.Add(code);
        }

        public void SetType(SecurityType type)
        {
            _types.Add(type.ToString().ToLower());
        }

        public override async Task<CompanySearchResponse> SendRequestAsync()
        {
            if (_codes.Count > 0)
                Parameters.Add("exchanges", string.Join(",", _codes));

            if (_types.Count > 0)
                Parameters.Add("types", string.Join(",", _types));

            if (Parameters.Count == 0)
                throw new ArgumentException("At least one of the following parameters must be set: Symbol Keyword, Exchange Code, Security Type");

            SetPath("markets/lookup?{0}", GetFormatedParams());

            return await base.SendRequestAsync();
        }
    }
}
