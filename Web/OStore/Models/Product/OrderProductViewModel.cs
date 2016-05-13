using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OStore.Models.Product
{
    public class OrderProductViewModel
    {
        public OrderProductViewModel()
        {
            Colors = new List<System.Web.Mvc.SelectListItem>();
            Sizes = new List<System.Web.Mvc.SelectListItem>();
        }

        public int Id { get; set; }

        [Display(Name = @"Order_Manual_Product_SKU", ResourceType = typeof(Resources.StringResource))]
        public string SKU { get; set; }

        [Display(Name = @"Order_Manual_Product_Name", ResourceType = typeof(Resources.StringResource))]
        public string Name { get; set; }

        [Display(Name = @"Order_Manual_Product_StockQuantity", ResourceType = typeof(Resources.StringResource))]
        public int StockQuantity { get; set; }

        [Display(Name = @"Order_Manual_Product_Color", ResourceType = typeof(Resources.StringResource))]
        [Required(ErrorMessage = @"Order_Manual_Product_Color_Required", ErrorMessageResourceType = typeof(Resources.StringResource))]
        public int ColorId { get; set; }

        [Display(Name = @"Order_Manual_Product_Size", ResourceType = typeof(Resources.StringResource))]
        [Required(ErrorMessage = @"Order_Manual_Product_Size_Required", ErrorMessageResourceType = typeof(Resources.StringResource))]
        public int SizeId { get; set; }

        [Display(Name = @"Order_Manual_Product_Price", ResourceType = typeof(Resources.StringResource))]
        public decimal Price { get; set; }

        [Display(Name = @"Order_Manual_Product_OrderQuantity", ResourceType = typeof(Resources.StringResource))]
        [Required(ErrorMessage = @"Order_Manual_Product_OrderQuantity_Required", ErrorMessageResourceType = typeof(Resources.StringResource))]
        public int OrderQuantity { get; set; }

        [Display(Name = @"Order_Manual_Product_Image", ResourceType = typeof(Resources.StringResource))]
        public string Image { get; set; }

        public List<System.Web.Mvc.SelectListItem> Colors { get; set; }
        public List<System.Web.Mvc.SelectListItem> Sizes { get; set; }
    }
}