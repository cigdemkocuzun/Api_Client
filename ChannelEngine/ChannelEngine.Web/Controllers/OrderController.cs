using ChannelEngine.Core;
using ChannelEngine.Core.Abstract.Order;
using ChannelEngine.Core.Abstract.Product;
using ChannelEngine.Core.Models;
using ChannelEngine.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Threading.Tasks;

namespace ChannelEngine.Web.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderService _orderService;
        private readonly IProductService _productService;
        public OrderController(IOrderService orderService, IProductService productService)
        {
            _orderService = orderService;
            _productService = productService;
        }

        public async Task<IActionResult> IndexAsync()
        {
            var orders =await _orderService.GetOrders();
            var top5SoldProducts =  _productService.GetTop5Products(orders);

            var viewModel = new OrderProductViewModel()
            {
                Orders = orders,
                Products = top5SoldProducts             
            };

            return View(viewModel);
        }

        public IActionResult UpdateProductStockOnOrder(string id)
        {
            _productService.UpdateStockAsync(id, 25);
            TempData["message"] = $" Product (" + id + " updated !)";
            return RedirectToAction("Index", "Order");
        }

    }
}
