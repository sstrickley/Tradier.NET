using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradierClient.Universe
{
    public class IndexRequest
    {
        private string _path;
        private IndexResponse _response;

        public IndexRequest(Index idx)
        {
            _path = IndexEndpoints.GetEndpoint(idx);
            _response = new IndexResponse { IndexName = idx.ToString() };
        }

        public async Task<IndexResponse> SendRequestAsync()
        {
            var web = new HtmlWeb();
            var doc = await web.LoadFromWebAsync(_path);

            await Task.Run(() => LoadConstituents(doc));
           
            Console.WriteLine("Doc loaded");

            return _response;
        }

        private void LoadConstituents(HtmlDocument doc)
        {
            _response.Constituents = doc.DocumentNode.Descendants("table")
                .Where(a => a.Descendants("tr")
                    .FirstOrDefault()?.Descendants("th")
                    .FirstOrDefault()?.InnerText.ToUpper() == "TICKER SYMBOL")
                .FirstOrDefault()?.Descendants("tr")
                .Skip(1)
                .Select(a => a.Descendants("td"))
                    .Select(b => new Constituent
                    {
                        Symbol = b.FirstOrDefault()?.InnerText,
                        Company = b.Skip(1).FirstOrDefault()?.InnerText,
                        Sector = b.Skip(3).FirstOrDefault()?.InnerText,
                        SubSector = b.Skip(4).FirstOrDefault()?.InnerText
                    })
                .ToList();
        }

    }
}
