namespace TradierClient
{
    using System.Threading.Tasks;

    public interface IRequest<TResponse>
    {
        Task<TResponse> SendRequestAsync();
    }
}
