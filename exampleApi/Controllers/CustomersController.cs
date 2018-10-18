using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TodoApi.Models;

namespace TodoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class CustomersController : ControllerBase
    {
        public readonly string Name;

        [HttpPost]
        public ActionResult<Customer> CreateCustomer([FromForm]Customer customer)
        {

         if (customer.Name == null)
            {
                return BadRequest(customer);
            }
            else
            {
                AddCustomer(customer);
                return Ok(customer);
            }
        }

        private void AddCustomer(Customer customer)
        {
            var path = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);

            using (StreamWriter file = new StreamWriter(Path.Combine(path, "Customers.txt")))
            {
                file.WriteLine(customer.Name);
            }
        }
    }
}