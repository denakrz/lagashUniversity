using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using TodoApi.Models;

namespace TodoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        public readonly string Name;
        public readonly string Age;
 
        [HttpPost]
        public ActionResult<Customer> CreateCostumer([FromBody]Customer customer)
        {
            SerializeObjectByType<Customer>(customer, Types.JSON);                   
            return Ok();
        }

        
        private void SerializeObjectByType<T>(T serializableObject, Types type)
         {
             if (type == Types.JSON)
             {
                 SerializeObjectJson(serializableObject);
             }
             else
             {
                 SerializeObjectXml(serializableObject);
             }
         }                                  
        

        private static string SerializeObjectXml<T>(T serializableObject)
        {
             var path = Path.Combine(Path.GetDirectoryName(Assembly.GetEntryAssembly().Location), "Example.xml");
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            XmlDocument xmlDocument = new XmlDocument();
           
            using (MemoryStream stream = new MemoryStream())
            {
                serializer.Serialize(stream, serializableObject);
                stream.Position = 0;
                xmlDocument.Load(stream);
                xmlDocument.Save(path);
            }

            return path;
        }

        private void SerializeObjectJson<T>(T serializableObject)
        {
            var path = Path.Combine(Path.GetDirectoryName(Assembly.GetEntryAssembly().Location), "Example.json");
            using (StreamWriter file = System.IO.File.CreateText(path))
            {
                JsonSerializer jsonSerializer = new JsonSerializer();
                jsonSerializer.Serialize(file, serializableObject);
            }
        }

    }
}