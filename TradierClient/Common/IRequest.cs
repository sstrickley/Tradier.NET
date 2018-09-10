namespace TradierClient
{
    using System.Threading.Tasks;

    public interface IRequest<T>
    {
        Task<T> SendRequestAsync();
    }
}
