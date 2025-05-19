using KanyeRest.Domain.Model;

namespace KanyeRest.Application.Services
{
    public interface IKanyeService
    {
        KanyeResponse GetInfo();
        Task<string> GetQuoteAsync();
    }
}
