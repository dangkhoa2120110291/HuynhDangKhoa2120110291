using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebsiteBanHang.Context;
namespace WebsiteBanHang.Models
{
    public class HomeModel
    {
        public Product Product { get; set; }
        public List<WebsiteBanHang.Context.Product> ListProduct { get; set; }
        public List<WebsiteBanHang.Context.Category> ListCategory { get; set; }
        public List<WebsiteBanHang.Context.Brand> ListBrand { get; set; }
    }
}