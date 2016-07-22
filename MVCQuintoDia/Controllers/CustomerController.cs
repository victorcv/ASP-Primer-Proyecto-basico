using MVCQuintoDia.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCQuintoDia.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult DisplayCustomer()
        {
            CustomerViewModel obj = new CustomerViewModel();
            obj.txtName = "Ronald";
            obj.txtAmount = "1000";
            return View(obj);
        }
    }
}