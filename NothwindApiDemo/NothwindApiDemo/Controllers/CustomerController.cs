using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace NothwindApiDemo.Controllers
{
    public class CustomerController: Controller
    {
        public JsonResult GetCustomers()
        {
            return new JsonResult(new List<object>()
            {
                new { CustomerID = 1, ContactName = "Anderson"},
                new { CustomerID = 2, ContactName = "Solaris"}
            });
        }

    }
}
