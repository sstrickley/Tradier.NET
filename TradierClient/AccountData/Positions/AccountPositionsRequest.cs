﻿namespace TradierClient.AccountData
{
    public class AccountPositionsRequest : BaseGetRequest<PositionsResponse>
    {
        public AccountPositionsRequest(AccessToken token, Account account) : base(token.access_token, Endpoints.Request)
        {
            SetPath(string.Format("accounts/{0}/positions", account.AccountNumber));
        }
    }
}