using KanyeRest.Domain.Model;
using KanyeRest.Infrastructure.Integrations;

namespace KanyeRest.Application.Services
{
    public class KanyeService : IKanyeService
    {
        private readonly IKanyeQuoteClient _quoteClient;

        public KanyeService(IKanyeQuoteClient quoteService)
        {
            _quoteClient = quoteService;
        }

        public KanyeResponse GetInfo() => new KanyeResponse();

        public Task<string> GetQuoteAsync() => _quoteClient.GetRandomQuoteAsync();
    }
}
