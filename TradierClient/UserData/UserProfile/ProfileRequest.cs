namespace TradierClient.UserData
{
    public class ProfileRequest : GetRequest<ProfileResponse>
    {
        public ProfileRequest(AccessToken token) : base(token, Endpoints.Request)
        {
            SetPath("user/profile");
        }
    }
}
