namespace TradierClient.UserData
{
    public class PositionsRequest : BaseGetRequest<PositionResponse>
    {
        public PositionsRequest(AccessToken token) : base(token.access_token, Endpoints.Request)
        {
            SetPath("user/positions");
        }
    }
}
