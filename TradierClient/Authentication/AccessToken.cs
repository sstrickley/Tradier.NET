namespace TradierClient
{
    public class AccessToken
    {
        public string access_token { get; set; }
        public int expires_in { get; set; }
        public string issued_at { get; set; }
        public string scope { get; set; }
        public string status { get; set; }
    }
}
