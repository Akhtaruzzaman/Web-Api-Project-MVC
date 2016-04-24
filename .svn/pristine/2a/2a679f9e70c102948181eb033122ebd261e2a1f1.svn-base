using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApi.Models;

namespace WebApi.Controllers
{
    public class OrderController : Controller
    {
        // GET: Order
        public ActionResult Index()
        {
            return View();
        }
        //Post action for Save data to database
        [HttpPost]
        public JsonResult SaveOrder(OrderVm O)
        {
            bool status = false;
            if (ModelState.IsValid)
            {
                using (InfoDbContext dc = new InfoDbContext())
                {
                    Order order = new Order { OrderNo = O.OrderNo, OrderDate = O.OrderDate, Description = O.Description };

                    dc.Orders.Add(order);
                    foreach (var i in O.OrderDetails)
                    {
                        i.OrderId = order.OrderId;
                        dc.OrderDetails.Add(i);
                    }
                    dc.SaveChanges();
                    status = true;
                }
            }
            else
            {
                status = false;
            }
            return new JsonResult { Data = new { status = status } };
        }

    }
}