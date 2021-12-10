using ChannelEngine.Core.Models.Order;
using ChannelEngine.Core.Models.Product;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace ChannelEngine.Core.Abstract.Product
{
    public interface IProductService
    {
        Task<IEnumerable<ProductModel>> GetAllProducts();
        IEnumerable<OrderProductLineModel> GetTop5Products(IEnumerable<OrderModel> orders);
        Task UpdateStockAsync(string merchantProductNo, int stock);

    }
}