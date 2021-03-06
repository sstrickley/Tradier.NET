﻿namespace TradierClient.Universe
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Net.Http.Headers;
    using System.Threading.Tasks;

    public class ExchangeRequest : GetRequest<ExchangeResponse>
    {
        private Exchange _exchange;

        public ExchangeRequest(Exchange exchange) : base(Endpoints.Nasdaq)
        {
            Parameters.Add("exchange", exchange.ToString());
            Parameters.Add("render", "download");

            _exchange = exchange;            
        }

        protected override void InitializeHttpClient(HttpClient client)
        {
            client.BaseAddress = _baseUri;
            client.Timeout = new TimeSpan(0, 1, 0);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Add("Accept", "text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8");
            client.DefaultRequestHeaders.Add("Accept-Encoding", "gzip,deflate,br");
            client.DefaultRequestHeaders.Add("Accept-Language", "en-US,en;q=0.5");
            client.DefaultRequestHeaders.Add("Connection", "keep-alive");
            
        }

        public override async Task<ExchangeResponse> SendRequestAsync()
        {
            SetPath("screening/companies-by-industry.aspx?{0}", GetFormatedParams());
            return await base.SendRequestAsync();
        }

        protected override async Task<ExchangeResponse> DeserializeResponse(HttpResponseMessage message)
        {
            using (StreamReader reader = new StreamReader(await message.Content.ReadAsStreamAsync()))
            {
                return await Task.Run(() => DeserializeCsv(reader));
            }
        }

        private ExchangeResponse DeserializeCsv(StreamReader reader)
        {
            var header = reader.ReadLine();

            var response = new ExchangeResponse();
            response.Date = DateTime.Today;
         
            while(!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var company = new CompanyInfo();
                company.Create(line);
                company.Exchange = _exchange.ToString();

                response.Companies.Add(company);
            }

            return response;
        }
    }
}
