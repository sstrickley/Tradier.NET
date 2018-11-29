using System;
using System.Threading;
using System.Threading.Tasks;

namespace TradierClient
{
    internal sealed class RequestManager
    {
        private static readonly Lazy<RequestManager> _instance = new Lazy<RequestManager>(() => new RequestManager());

        public static RequestManager I
        {
            get { return _instance.Value; }
        }

        private readonly int REQUEST_PER_MINUTE_LIMIT = 80;
        private SemaphoreSlim semSlim = new SemaphoreSlim(1, 1);
        private DateTime _lastRequest;

        private RequestManager()
        { }

        public async Task Throttle()
        {
            await semSlim.WaitAsync();

            try
            {
                var secPerReq = 60 / REQUEST_PER_MINUTE_LIMIT;
                var secSinceLast = (DateTime.Now - _lastRequest).Seconds;

                var diff = secPerReq - secSinceLast;

                if (diff > 0)
                    await Task.Delay(diff);

                _lastRequest = DateTime.Now;
            }
            finally
            {
                semSlim.Release();
            }

        }
    }
}
