namespace TradierClient.UserData
{
    public class PositionsRequest : GetRequest<PositionResponse>
    {
        public PositionsRequest(AccessToken token) : base(token, Endpoints.Request)
        {
            SetPath("user/positions");
        }
    }
}
