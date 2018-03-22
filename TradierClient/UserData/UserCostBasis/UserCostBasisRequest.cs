namespace TradierClient.UserData
{
    public class UserCostBasisRequest : GetRequest<UserCostBasisResponse>
    {
        public UserCostBasisRequest(AccessToken token) : base(token, Endpoints.Request)
        {
            SetPath("user/gainloss");
        }
    }
}
