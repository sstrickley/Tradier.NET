namespace TradierClient.UserData
{
    public class ProfileRequest : BaseGetRequest<ProfileResponse>
    {
        public ProfileRequest(AccessToken token) : base(token.access_token, Endpoints.Request)
        {
            SetPath("user/profile");
        }
    }
}
