using ChannelEngine.Core.Abstract.Order;
using ChannelEngine.Core.Abstract.Product;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using Moq;
using Xunit;
using ChannelEngine.Core.Abstract.RestApi;
using ChannelEngine.Core.Concrete.Product;
using ChannelEngine.Core.Concrete.Order;

namespace ChannelEngine.Tests
{
    public class ProductTests
    {
        private readonly IProductService _productService;
        private readonly IOrderService _orderService;
        Mock<IRestApiService> _restApiMock;
        public ProductTests()
        {
            _restApiMock = new Mock<IRestApiService>();
            _productService = new ProductService(_restApiMock.Object);
            _orderService = new OrderService(_restApiMock.Object);
        }
        [Fact]
        public void ShouldReturnTop5Products()
        {

           var orders = _orderService.GetOrders().Result;
            var result = _productService.GetTop5Products(orders);
            //assert
            Xunit.Assert.Equal(5, result.Count());
        }

    }
}
