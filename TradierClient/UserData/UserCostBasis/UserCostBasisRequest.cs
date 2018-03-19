namespace TradierClient.UserData
{
    public class UserCostBasisRequest : BaseGetRequest<UserCostBasisResponse>
    {
        public UserCostBasisRequest(AccessToken token) : base(token.access_token, Endpoints.Request)
        {
            SetPath("user/gainloss");
        }
    }
}
