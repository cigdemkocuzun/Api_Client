using System;
using System.Collections.Generic;

namespace ChannelEngine.Core.Models.Order
{
    public class MerchantOrderModel
    {
        public IEnumerable<OrderModel> Content { get; set; }
    }

}