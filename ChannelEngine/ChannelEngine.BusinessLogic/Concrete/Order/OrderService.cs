using System.Collections.Generic;
using System.Threading.Tasks;
using ChannelEngine.Core.Abstract.Order;
using ChannelEngine.Core.Abstract.RestApi;
using ChannelEngine.Core.Enums;
using ChannelEngine.Core.Models.Order;
using Newtonsoft.Json;
using RestSharp;

namespace ChannelEngine.Core.Concrete.Order
{
    public class OrderService : IOrderService
    {
        private readonly IRestApiService _restApiService;
        public OrderService(IRestApiService restApiService)
        {
            _restApiService = restApiService;
        }
        public async Task<IEnumerable<OrderModel>> GetOrders()
        {
            var request = new RestRequest("orders", Method.GET);
            request.AddQueryParameter("statuses",nameof(OrderStatus.IN_PROGRESS));

            var restResponse = await _restApiService.ExecuteTask(request);

            var data = JsonConvert.DeserializeObject<MerchantOrderModel>(restResponse.Content).Content;
            return data;
        }
    }
}
