using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;
using WebApplication2.Repository;

namespace WebApplication2.Controllers
{
    public class PostulantController : ControllerBase
    {
        private readonly IPostulantRepository repository;

        public PostulantController(IPostulantRepository repositoryGenerate)
        {
            this.repository = repositoryGenerate;
        }

       [Route("/api/Postulant/{id}")]
       
       public Postulant Get(int id)
        {
            return repository.GetPostulant(id);
        }

        // Obtener lista

        [HttpGet]
        [Route("/api/Postulant/")]
        public IEnumerable<Postulant> Get()
        {
            return repository.GetPostulantAll();
        }

        [HttpPost]
        [Route("/api/Postulant/")]
        public ActionResult Post([FromBody] Postulant postulant)
        {
            if (ModelState.IsValid && (postulant.Name.IndexOf(" ") != -1)) // Si hay un espacio en el nombre (nombre + apellido) lo agrega
            {
                repository.Insert(postulant);
            }
            else
            {
                return NotFound(); // Si no, devuelve 404.
            }
            return Ok();
        }

        // En el Put puedo poner nombres sin espacios, la validación me arroja un error CS0029 por la ID (es int), ¿tengo que convertir todo a string?

        [HttpPut]
        [Route("/api/Postulant/")]
        public ActionResult Put([FromBody] Postulant postulant)
        {
            if (ModelState.IsValid && (postulant.Name.IndexOf(" ") != -1))
            {
                repository.Update(postulant);
            }
            else
            {
                return NotFound();
            }

            return Ok();

        }
        

        // Eliminar un registro por ID

        [HttpDelete]
        [Route("/api/Postulant/{id}")]
        public void Delete(int id)
        {
            repository.Delete(id);
        }

        // Ejemplo GET Login (implementar en proyecto).

        [HttpGet]
        [Route("/api/Login")]
        public IActionResult Login()
        {
            return Redirect("https://Lagash.com");
        }
    }
}
