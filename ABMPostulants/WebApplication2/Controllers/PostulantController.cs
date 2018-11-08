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
            if (ModelState.IsValid && (postulant.Name.IndexOf(" ") != -1)) // Para saber si hay un espacio en el nombre
            {
                repository.Insert(postulant);
            }
            else
            {
                return NotFound();
            }
            return Ok();
        }

        [HttpPut]
        [Route("/api/Postulant/")]
        public Postulant Put([FromBody] Postulant postulant)
        {

            return repository.Update(postulant);
        }

        [HttpDelete]
        [Route("/api/Postulant/{id}")]
        public void Delete(int id)
        {
            repository.Delete(id);
        }

        [HttpGet]
        [Route("/api/Login")]
        public IActionResult Login()
        {
            return Redirect("https://Lagash.com");
        }
    }
}
