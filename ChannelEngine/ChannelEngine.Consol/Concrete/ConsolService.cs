
using ChannelEngine.Core.Abstract.Order;
using ChannelEngine.Core.Abstract.Product;
using ChannelEngine.Core.Models.Order;
using ChannelEngine.Core.Models.Product;
using ConsoleTables;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ChannelEngine.Consol
{
    public class ConsolService : IConsolService
    {
        private readonly IOrderService _orderService;
        private readonly IProductService _productService;

        public ConsolService(IOrderService orderService, IProductService productService)
        {
            _orderService = orderService;
            _productService = productService;
        }
        public async Task GetOrdersAndProducts()
        {
            var orders = await _orderService.GetOrders();
            var products = _productService.GetTop5Products(orders);

            WriteOrderTable(orders);
            WriteProductTable(products);
        }

        private void WriteOrderTable(IEnumerable<OrderModel> orders)
        {

            Console.WriteLine("ORDERS LIST ( STATUS:IN_PROGRESS ) ");
            var table = new ConsoleTable("Id", "Channel Name", "Payment Method", "Channel Order No", "Order Date");

            foreach (var order in orders)
            {
                table.AddRow(order.ChannelId, order.ChannelName, order.PaymentMethod, order.ChannelOrderNo, order.OrderDate);
            };

            Console.WriteLine(table.ToString());
            Console.WriteLine("");
        }

        private void WriteProductTable(IEnumerable<OrderProductLineModel> products)
        {
            Console.WriteLine("TOP 5 SOLD PRODUCT LIST");
            var tableProduct = new ConsoleTable("Channel Product No", "Name", "Gtin", "Merchant Product No", "Quantity");

            foreach (var product in products)
            {
                tableProduct.AddRow(product.ChannelProductNo, product.Description, product.Gtin, product.MerchantProductNo, product.Quantity);
            }

            Console.WriteLine(tableProduct.ToString());
            Console.WriteLine("");
        }

        public async Task<string> UpdateProductStock(string productNo)
        {
            try
            {
                await _productService.UpdateStockAsync(productNo, 25);
                return "Success!";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public void ShowError(Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}