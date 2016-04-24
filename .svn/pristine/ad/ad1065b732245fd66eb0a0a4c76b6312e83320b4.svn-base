using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApi.Models
{
    public class OrderDetail
    {
        [Key]
        public int OrderItemId { get; set; }
        [Display(Name = "Order Id")]
        public int OrderId { get; set; }
        [Display(Name = "Item Name")]
        public string ItemName { get; set; }
        [Display(Name = "Quantity")]
        public int Quantity { get; set; }
        [Display(Name = "Rate")]
        public decimal Rate { get; set; }
        [Display(Name = "Total Amount")]
        public decimal TotalAmount { get; set; }

        internal ActionResult View(object webControls)
        {
            throw new NotImplementedException();
        }
    }
}