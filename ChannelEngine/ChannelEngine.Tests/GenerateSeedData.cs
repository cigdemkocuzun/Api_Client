

using ChannelEngine.Core.Models.Order;
using ChannelEngine.Core.Models.Product;

namespace ChannelEngine.Tests
{
    public class GenerateSeedData
    {
        public static MerchantOrderModel CreateDummyData()
        {
            var product = new OrderProductLineModel
            {
            
                MerchantProductNo = "MSGH1-S",
                Gtin = "1234567890",
                Quantity = 20,
            };

            var productSecond = new OrderProductLineModel
            {
                Quantity = 5,
                MerchantProductNo = "MSGH1-X",
                Gtin = "1234567890"
            };

            var productSecondThird = new OrderProductLineModel
            {
                Quantity = 5,
                MerchantProductNo = "MSGH1-M",
                Gtin = "1234567890"
            };

            var productSecondFourth = new OrderProductLineModel
            {
                Quantity = 5,
                MerchantProductNo = "MSGH1-M1",
                Gtin = "1234567890"
            };

            var productSecondFifth = new OrderProductLineModel
            {
                Quantity = 5,
                MerchantProductNo = "MSGH1-M2",
                Gtin = "1234567890"
            };

            var productSecondSixth = new OrderProductLineModel
            {
                Quantity = 7,
                MerchantProductNo = "MSGH1-M3",
                Gtin = "1234567890"
            };

            var order = new OrderModel
            {
                Lines = new OrderProductLineModel[2] { product, productSecond }
            };

            var order2 = new OrderModel
            {
                Lines = new OrderProductLineModel[4] { productSecondThird, productSecondFourth, productSecondFifth, productSecondSixth }
            };

            var response = new MerchantOrderModel
            {
                Content = new OrderModel[2] { order, order2 }
            };
            return response;
        }
    }
}
