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
    [Route("api/[controller]")] // el route me da un URI para invocar a traves de una petitud HTTP los recursos que me da la API.
    [ApiController]  // lo hace solo el framework gracias a route("api/[controller])

    public class CustomersController : ControllerBase // nombre del controller, el framework busca esta clase para modificar el [/controller]
    {
        public readonly string Name;

        [HttpPost]  // atributo necesario para que el metodo se ejecute siempre y cuando la petitud HTTP respete la URI y el METODO 
        public ActionResult<Customer> CreateCustomer([FromForm]Customer customer) // serialización, si respeto la ruta y el metodo, se acciona esto
        {


            if (string.IsNullOrEmpty(customer.Name)) // si customer está vacío o nulo
            {
                return BadRequest(customer); // retorna 400
            }
            else // sino
            {
                AddCustomer(customer); // agrega customer
                return Ok(customer); // retorna 200
            }
        }

        [HttpGet]

        public ActionResult<Customer> GetCustomer()
        {
            Customer customer = new Customer(); // construyo un nuevo costumer
            customer.Name = "Denise"; // agrego valor nombre
            return Ok(customer); // retorna 200

            /* Constructor dinámico: solo cuando se pueden setear atributos publicos, se crea un constructor en customer.cs 
            Customer customer = new Costumer ();
            {
                Name = "Horacio";
            };
            return Ok(customer);
             */
        }

        private void AddCustomer(Customer customer) // metodo que guarda en el customer
        {
            var path = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);

            using (StreamWriter file = new StreamWriter(Path.Combine(path, "Customers.txt")))
            {
                file.WriteLine(customer.Name);
            }
        }
    }
}