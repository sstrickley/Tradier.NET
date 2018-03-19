﻿namespace TradierClient.AccountData
{
    public class AccountOrdersRequest : BaseGetRequest<AccountOrdersResponse>
    {
        public AccountOrdersRequest(AccessToken token, Account account) : base(token.access_token, Endpoints.Request)
        {
            SetPath(string.Format("accounts/{0}/orders", account.AccountNumber));
        }
    }
}
