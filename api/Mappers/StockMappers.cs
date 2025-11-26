using api.Dtos.Stock;
using api.Models;

namespace api.Mappers
{
    public static class StockMappers
    {
        public static StockDto ToStockDto(this Stock stock)
        {
            return new StockDto
            {
                Id = stock.Id,
                Symbol = stock.Symbol,
                CompanyName = stock.CompanyName,
                Purchase = stock.Purchase,
                LastDiv = stock.LastDiv,
                Industry = stock.Industry,
                MarketCap = stock.MarketCap,
                Comments = stock.Comments.Select(c => c.ToCommentDto()).ToList()
            };
        }

        public static Stock ToStockFromCreateDTO(this CreateStockRequestDto stockDto)
        {
            return new Stock
            {
                Symbol = stockDto.Symbol,
                CompanyName = stockDto.CompanyName,
                Purchase = stockDto.Purchase,
                LastDiv = stockDto.LastDiv, 
                Industry = stockDto.Industry,
                MarketCap = stockDto.MarketCap
            };
        }
        
        public static Stock ToStockFromFMT(this FMPStock fmtStock)
        {
            return new Stock
            {
                Symbol = fmtStock.symbol,
                CompanyName = fmtStock.companyName,
                Purchase = (decimal)fmtStock.price,
                LastDiv = (decimal)fmtStock.lastDividend, 
                Industry = fmtStock.industry,
                MarketCap = fmtStock.marketCap
            };
        }
    }
}
