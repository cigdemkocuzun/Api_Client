using Bogus;
using ChannelEngine.Core.Abstract.Product;
using ChannelEngine.Core.Abstract.RestApi;
using ChannelEngine.Core.Concrete.Product;
using ChannelEngine.Core.Models.Order;
using ChannelEngine.Core.Models.Product;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Collections.Generic;
using System.Linq;


namespace ChannelEngine.Tests
{
    [TestClass]
    public class ProductTests
    {
        private readonly IProductService _productService;
        Mock<IRestApiService> _serviceMock;
        public ProductTests()
        {
            _serviceMock = new Mock<IRestApiService>();
            _productService = new ProductService(_serviceMock.Object);
        }

        [TestMethod]
        public void ShouldReturnTop5Products()
        {

            var result = _productService.GetTop5Products(GenerateData());
            Assert.AreEqual(result.Count(), 5);
        }

        public static IEnumerable<OrderModel> GenerateData()
        {

            Faker faker = new Faker();

            var product1 = new OrderProductLineModel
            {

                MerchantProductNo = "001201-S",
                ChannelProductNo = faker.IndexGlobal.ToString(),
                Gtin = faker.Random.Number(1, 99999).ToString(),
                Description = faker.Random.Words(5),
                Quantity = faker.Random.Number(1, 10)
            };

            var product2 = new OrderProductLineModel
            {
                MerchantProductNo = "0001201-M",
                ChannelProductNo = faker.IndexGlobal.ToString(),
                Gtin = faker.Random.Number(1, 99999).ToString(),
                Description = faker.Random.Words(5),
                Quantity = faker.Random.Number(1, 10)
            };

            var product3 = new OrderProductLineModel
            {
                MerchantProductNo = "001201-S",
                ChannelProductNo = faker.IndexGlobal.ToString(),
                Gtin = faker.Random.Number(1, 99999).ToString(),
                Description = faker.Random.Words(5),
                Quantity = faker.Random.Number(1, 10)
            };

            var product4 = new OrderProductLineModel
            {
                MerchantProductNo = "0001201-L",
                ChannelProductNo = faker.IndexGlobal.ToString(),
                Gtin = faker.Random.Number(1, 99999).ToString(),
                Description = faker.Random.Words(5),
                Quantity = faker.Random.Number(1, 10)
            };

            var product5 = new OrderProductLineModel
            {
                MerchantProductNo = "0001202-S",
                ChannelProductNo = faker.IndexGlobal.ToString(),
                Gtin = faker.Random.Number(1, 99999).ToString(),
                Description = faker.Random.Words(5),
                Quantity = faker.Random.Number(1, 10)
            };

            var product6 = new OrderProductLineModel
            {
                MerchantProductNo = "0001202-XL",
                ChannelProductNo = faker.IndexGlobal.ToString(),
                Gtin = faker.Random.Number(1, 99999).ToString(),
                Description = faker.Random.Words(5),
                Quantity = faker.Random.Number(1, 10)
            };

            var product7 = new OrderProductLineModel
            {
                MerchantProductNo = "0001202 - XL",
                ChannelProductNo = faker.IndexGlobal.ToString(),
                Gtin = faker.Random.Number(1, 99999).ToString(),
                Description = faker.Random.Words(5),
                Quantity = faker.Random.Number(1, 10)
            };

            var order = new OrderModel
            {
                Lines = new OrderProductLineModel[2] { product1, product2 }
            };

            var order2 = new OrderModel
            {
                Lines = new OrderProductLineModel[2] { product3, product4 }
            };

            var order3 = new OrderModel
            {
                Lines = new OrderProductLineModel[2] { product5, product6 }
            };

            List<OrderModel> model = new List<OrderModel>();
            model.Add(order);
            model.Add(order2);
            model.Add(order3);
            return model;

        }

    }
}
