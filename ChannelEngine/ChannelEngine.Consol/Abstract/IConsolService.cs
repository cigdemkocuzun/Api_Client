using System;
using System.Threading.Tasks;

namespace ChannelEngine.Consol
{
    public interface IConsolService
    {
        Task GetOrdersAndProducts();
        Task<string> UpdateProductStock(string productNo);
        void ShowError(Exception exception);
    }
}