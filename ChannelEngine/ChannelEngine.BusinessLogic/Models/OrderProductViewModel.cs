
using ChannelEngine.Core.Models.Order;
using ChannelEngine.Core.Models.Product;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChannelEngine.Core.Models
{
    public class OrderProductViewModel
    {
        public IEnumerable<OrderModel> Orders { get; set; }
        public IEnumerable<OrderProductLineModel> Products { get; set; }
    }
}
