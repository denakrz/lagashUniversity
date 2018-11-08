using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Models;

namespace WebApplication2.Repository
{
    public interface IPostulantRepository
    {
        void Insert(Postulant postulant);
        Postulant GetPostulant(int id);
        IEnumerable<Postulant> GetPostulantAll();
        void Delete(int id);
        Postulant Update(Postulant postulant);

    }
}
