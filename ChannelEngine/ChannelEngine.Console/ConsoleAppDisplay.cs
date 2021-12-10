

using System;
using System.Collections.Generic;

namespace ChannelEngine.Consol
{
    public class ConsoleAppDisplay : IConsoleAppDisplay
    {
        public void DisplayInProgressOrders()
        {
            Console.WriteLine("List of all Orders with IN_PROGRESS status:");
            Console.WriteLine("Id | Channel Name | Created ");

            foreach (var order in orders)
            {
                Console.WriteLine($"{order.Id} | {order.ChannelName} | {order.CreatedAt.ToShortDateString()} ");
                foreach (var product in order.Products)
                {
                    Console.WriteLine(
                        $"      Product: {product.MerchantProductNo} |  {product.Quantity}");
                }
            }
        }
    }
//public void DisplayTop5Products(IEnumerable<Product> products)
//{
//    Console.WriteLine("List of top 5 products sold:");
//    Console.WriteLine("Product Number | Gtin | Quantity | Stock");

//    foreach (var product in products)
//    {
//        Console.WriteLine(
//            $"{product.Name} | {product.MerchantProductNo} | {product.Gtin} | {product.Quantity} | {product.Stock}");
//    }
//}

//public string GetProductNumberForUpdateStock()
//{
//    Console.WriteLine("Type product number to update Stock:");
//    var productNumber = Console.ReadLine();
//    return productNumber;
//}

//public void DisplayProduct(Product product)
//{
//    Console.WriteLine($"Product:");
//    Console.WriteLine($"Name: {product.Name}");
//    Console.WriteLine($"MerchantProductNo: {product.MerchantProductNo}");
//    Console.WriteLine($"Stock: {product.Stock}");
//    Console.WriteLine($"Quantity: {product.Quantity}");
//}

//public void DisplayError(Exception ex)
//{
//    Console.WriteLine($"Error: {ex.Message}");
//    Console.WriteLine($"StackTrace: {ex.StackTrace}");
//}
//}
//}
