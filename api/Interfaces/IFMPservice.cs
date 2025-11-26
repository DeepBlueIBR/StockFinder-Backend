using api.Models;

namespace api.Interfaces
{

    public interface IFMPservice
    {
        Task<Stock> FindStockBySymbolAsync(string symbol);
            
    }

}
