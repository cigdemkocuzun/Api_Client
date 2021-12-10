namespace ChannelEngine.Core.Models.Product
{
    public class OrderProductLineModel
    {
        public string MerchantProductNo { get; set; }
        public string Description { get; set; }
        public string ChannelProductNo { get; set; }
        public string Gtin { get; set; }
        public int Quantity { get; set; }
    }
}
