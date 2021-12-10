using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChannelEngine.Core.Abstract.Product;
using ChannelEngine.Core.Abstract.RestApi;
using ChannelEngine.Core.Models.Order;
using ChannelEngine.Core.Models.Product;
using Newtonsoft.Json;
using RestSharp;

namespace ChannelEngine.Core.Concrete.Product
{
    public class ProductService : IProductService
    {
        private readonly IRestApiService _restApiService;
        public ProductService(IRestApiService restApiService)
        {
            _restApiService = restApiService;
        }

        public async Task<IEnumerable<ProductModel>> GetAllProducts()
        {
            var request = new RestRequest("products", Method.GET);

            var restResponse = await _restApiService.ExecuteTask(request);

            if (!restResponse.IsSuccessful)
            {
                throw new Exception("Error!");
            }

            var data = JsonConvert.DeserializeObject<MerchantProductModel>(restResponse.Content).Content;
            return data;
        }
        public IEnumerable<OrderProductLineModel> GetTop5Products(IEnumerable<OrderModel> orders)
        {
            var top5SoldProducts = orders.SelectMany(order => order.Lines)
                .GroupBy(line => line.MerchantProductNo)
                .Select(line => new OrderProductLineModel
                {
                    MerchantProductNo = line.First().MerchantProductNo,
                    ChannelProductNo = line.First().ChannelProductNo,
                    Gtin = line.First().Gtin,
                    Description = line.First().Description,
                    Quantity = line.Sum(l => l.Quantity),
                })
                .OrderByDescending(prod => prod.Quantity)
                .Take(5);

            return top5SoldProducts;
        }

        public async Task UpdateStockAsync(string merchantProductNo, int stock)
        {
            var request = new RestRequest("offer", Method.PUT);
            var requestBody = new ProductsStockUpdateRequestModel
            {
                MerchantProductNo = merchantProductNo,
                Stock = stock
            };

            request.RequestFormat = DataFormat.Json;
            request.AddBody(new[] { requestBody });

            var restResponse =  await _restApiService.ExecuteTask(request);

            if (!restResponse.IsSuccessful)
            {
                throw new Exception("Error!");
            }

        }

    }
}
