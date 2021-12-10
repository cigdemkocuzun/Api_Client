namespace ChannelEngine.Core.Models.Product
{

    public class ProductModel
    {
        public string MerchantProductNo { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Brand { get; set; }
        public string Size { get; set; }
        public string Color { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }
    }
}