﻿namespace TradierClient.AccountData
{
    public class AccountHistoryRequest : BaseGetRequest<AccountHistoryResponse>
    {
        public AccountHistoryRequest(AccessToken token, Account account) : base(token.access_token, Endpoints.Request)
        {
            SetPath("accounts/{0}/history", account.AccountNumber);
        }
    }
}
