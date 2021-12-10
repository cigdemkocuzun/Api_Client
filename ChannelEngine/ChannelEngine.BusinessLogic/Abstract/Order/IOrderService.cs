using System.Collections.Generic;
using System.Threading.Tasks;
using ChannelEngine.Core.Models.Order;

namespace ChannelEngine.Core.Abstract.Order
{
    public interface IOrderService
    {
        Task<IEnumerable<OrderModel>> GetOrders();
    }
}