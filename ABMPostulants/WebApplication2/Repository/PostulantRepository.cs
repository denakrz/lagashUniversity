using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Models;

namespace WebApplication2.Repository
{
    public class PostulantRepository : IPostulantRepository
    {
        private string connStr = @"Server=(localdb)\MSSQLLocalDB;Database=exercise;Integrated Security=true"; // conección a DB

        public Postulant GetPostulant(int id)
        {
            var sql = "select * from Postulant u inner join Country c on c.IdCountry = u.IdCountry where Id = @Id"; // creo variable para no tener que tipear la query

            using (var conn = new SqlConnection(connStr))
            {
                conn.Open();
                Postulant postulant = conn
                    .Query<Postulant, Country, Postulant>(sql, param: new { Id = id }, map: GetCountry, splitOn: "IdCountry") // Mapea relaciones entre Sql
                    .FirstOrDefault();
                conn.Close();

                return postulant;
            }
        }

        // DELETE //

        public void Delete(int id)
        {
            var sql = "delete Postulant where Id = @Id";

            using (var conn = new SqlConnection(connStr))
            {
                conn.Open();
                conn.Execute(sql, new { Id = id });
                conn.Close();
            }
        }

        // RETORNA TABLA //

        public IEnumerable<Postulant> GetPostulantAll()
            {
                var sql = "select * from Postulant u inner join Country c on c.IdCountry = u.IdCountry"; // Selecciona ambas tablas

                using (var conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    IEnumerable<Postulant> postulantsList = conn
                    .Query<Postulant, Country, Postulant>(sql, map: GetCountry, splitOn: "IdCountry");
                    conn.Close();

                    return postulantsList;

                }
            }

        // INSERTA VALORES //

        public void Insert(Postulant postulant)
            {
                var sql = "insert into Postulant (Name, Age, IdCountry) values (@Name, @Age, @IdCountry)";

                using (var conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    conn.Execute(sql, new { @Name = postulant.Name, @Age = postulant.Age, @IdCountry = postulant.Country.IdCountry }); // Creo nuevo obj para relacionar los valores
                    conn.Close();
                }
            }

        // ACTUALIZA VALORES //

            public Postulant Update(Postulant postulant)
            {
                var sql = "update Postulant set Name = @Name, Age = @Age, IdCountry = @IdCountry where Id = @Id";

                using (var conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    conn.Execute(sql, new { @Name = postulant.Name, @Age = postulant.Age, @IdCountry = postulant.Country.IdCountry, @Id = postulant.Id });
                    conn.Close();
                }

                return this.GetPostulant(postulant.Id);
            }

        private Postulant GetCountry(Postulant postulant, Country country)
        {
            postulant.Country = country;
            return postulant;
        }
    }
}
