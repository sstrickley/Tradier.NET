namespace TradierClient.Universe
{
    using System.Collections.Generic;

    public class IndexResponse
    {
        public int Id { get; set; }

        public string IndexName { get; set; }

        public List<Constituent> Constituents { get; set; }

        public IndexResponse()
        {
            Constituents = new List<Constituent>();
        }
    }
}