using OStore.Models.Product;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OStore.Models.SaleChannel
{
    public class OrderManualViewModel
    {
        public OrderManualViewModel()
        {
            Products = new List<OrderProductViewModel>();
        }

        [Display(Name = @"Order_Manual_OrderId", ResourceType = typeof(Resources.StringResource))]
        public string OrderId { get; set; }

        [Display(Name = @"Order_Manual_Link", ResourceType = typeof(Resources.StringResource))]
        public string RegisterLink { get; set; }

        [Display(Name = @"Order_Manual_OrderDate", ResourceType = typeof(Resources.StringResource))]
        public DateTime OrderDate { get; set; }

        [Display(Name = @"Order_Manual_Status", ResourceType = typeof(Resources.StringResource))]
        public string Status { get; set; }

        [Display(Name = @"Order_Manual_CustomerId", ResourceType = typeof(Resources.StringResource))]
        public int CustomerId { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }

        [Required(ErrorMessage = @"Order_Manual_Quantity_Required", ErrorMessageResourceType = typeof(Resources.StringResource))]
        [Display(Name = @"Order_Manual_Quantity", ResourceType = typeof(Resources.StringResource))]
        public int Quantity { get; set; }

        [Display(Name = @"Order_Manual_TotalAmount", ResourceType = typeof(Resources.StringResource))]
        public decimal TotalAmount { get; set; }

        [Display(Name = @"Order_Manual_DeliveryChannel", ResourceType = typeof(Resources.StringResource))]
        public int DeliveryChannelId { get; set; }

        public decimal DeliveryAmount { get; set; }

        [Display(Name = @"Order_Manual_DiscountAmount", ResourceType = typeof(Resources.StringResource))]
        public decimal DiscountAmount { get; set; }

        [Display(Name = @"Order_Manual_GrandTotalAmount", ResourceType = typeof(Resources.StringResource))]
        public decimal GrandTotalAmount { get; set; }

        [Display(Name = @"Order_Manual_Remark", ResourceType = typeof(Resources.StringResource))]
        public string Remark { get; set; }

        [Display(Name = @"Order_Manual_ProductList", ResourceType = typeof(Resources.StringResource))]
        public List<OrderProductViewModel> Products { get; set; }
    }
}