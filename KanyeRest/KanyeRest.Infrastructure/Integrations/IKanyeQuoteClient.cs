namespace KanyeRest.Infrastructure.Integrations
{
    public interface IKanyeQuoteClient
    {
        Task<string> GetRandomQuoteAsync();
    }
}
