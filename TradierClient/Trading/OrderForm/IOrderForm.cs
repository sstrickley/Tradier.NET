namespace TradierClient.Trading
{
    using System.Collections.Generic;

    public interface IOrderForm
    {
        bool IsValid();
        Dictionary<string, string> GetPostParameters();
    }
}
