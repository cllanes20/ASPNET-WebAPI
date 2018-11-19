﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace NothwindApiDemo.Controllers
{
    //api/customers/23/orders/id
    [Route("api/customers")]
    public class OrdersController: Controller
    {
        [HttpGet("{customerId}/orders")]
        public IActionResult GetOrders(int customerId)
        {
            var customer = Repository.Instance.Customers.FirstOrDefault(c => c.Id == customerId);
            if(customer == null)
            {
                return NotFound();
            }

            return Ok(customer.Orders);
        }

        [HttpGet("{customerId}/orders/{id?}")]
        public IActionResult GetOrder(int customerId, int id)
        {
            var customer = Repository.Instance.Customers.FirstOrDefault(c => c.Id == customerId);
            if (customer == null)
            {
                return NotFound();
            }

            var order = customer.Orders.FirstOrDefault(o => o.OrderId == id);
            if (order == null)
            {
                return NotFound();
            }
            return Ok(order);
        }
    }
}
