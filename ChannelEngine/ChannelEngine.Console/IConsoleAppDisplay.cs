
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ChannelEngine.Console
{
    public interface IConsoleAppDisplay
    {
        void DisplayInProgressOrders(IEnumerable<OrderModel> orders);
        void DisplayTop5Products(IEnumerable<Product> products);
        string GetProductNumberForUpdateStock();
        void DisplayProduct(Product product);

    }
}