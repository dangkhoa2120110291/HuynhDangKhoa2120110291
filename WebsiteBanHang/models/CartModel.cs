using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebsiteBanHang.Context;

namespace WebsiteBanHang.Models
{
    public class CartModel
    {
        public Product product { get; set; }
        public Context.Product Product { get; internal set; }
        public int Quantity { get; set; }
    }
}