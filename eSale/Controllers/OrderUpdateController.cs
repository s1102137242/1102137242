using System;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using eSale.Models;

namespace eSale.Controllers
{
    public class OrderUpdateController : Controller
    {
        // GET: OrderUpdate
        [HttpGet]
        public ActionResult UpdateIndex(string OrderID)
        {
            OrdersService OrderService = new OrdersService();
            ViewBag.select = OrderService.SelectOrderByID(OrderID);


            return View();
        }
    }
}