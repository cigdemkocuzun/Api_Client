using ChannelEngine.Core.Abstract.Product;
using ChannelEngine.Core.Models.Product;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;


namespace ChannelEngine.Web.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        private readonly ILogger _logger;
        public ProductController(IProductService productService, ILogger<ProductController> logger)
        {
            _productService = productService;
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Edit(string id, string name, int stock)
        {
            var model = new ProductModel
            {
                MerchantProductNo = id,
                Name = name,
                Stock = stock
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> EditAsync(ProductModel model)
        {
            if (string.IsNullOrEmpty(model.MerchantProductNo))
            {
                return View(model);
            }
            else
            {
                await _productService.UpdateStockAsync(model.MerchantProductNo, model.Stock);
                TempData["message"] = $" Product (" + model.MerchantProductNo + " updated !)";
                return RedirectToAction("Index", "Product");
            }
        }

        public async Task<IActionResult> IndexAsync()
        {
            var model = await _productService.GetAllProducts();

            return View(model);
        }

    }
}
