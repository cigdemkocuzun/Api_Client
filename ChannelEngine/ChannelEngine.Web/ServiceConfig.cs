using System.Reflection;
using ChannelEngine.Core;
using ChannelEngine.Core.Abstract.Order;
using ChannelEngine.Core.Abstract.Product;
using ChannelEngine.Core.Abstract.RestApi;
using ChannelEngine.Core.Concrete.Order;
using ChannelEngine.Core.Concrete.Product;
using ChannelEngine.Core.Concrete.RestApi;
using Microsoft.Extensions.DependencyInjection;

namespace ChannelEngine.Web
{
    public static class ServiceConfig
    {
        public static IServiceCollection RegisterToDependencies(this IServiceCollection services)
        {
            services.AddScoped<IOrderService, OrderService>();
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<IRestApiService, RestApiService>();
            return services;
        }
    }
}
