namespace ChannelEngine.Core.Models.Product
{
    public class ProductsStockUpdateRequestModel
    {
        public string MerchantProductNo { get; set; }
        public int Stock { get; set; }
    }

    public class ProductStockUpdateRequest
    {
        public ProductsStockUpdateRequestModel[] ProductStockUpdate { get; set; }
    }

}
