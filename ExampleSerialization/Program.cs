using System;
using System.IO;
using System.Reflection;
using System.Xml;
using System.Xml.Serialization;
using ExampleSerialization.Models;

namespace ExampleSerialization
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer(); // instacio costumer
            customer.Name = "Denise";
            SerializeObjectByType<Customer>(customer,Types.XML); //llamo al metodo


        }

        static void SerializeObjectByType<T>(T serializableObject, Types type)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            XmlDocument xmlDocument = new XmlDocument();
            var path = Path.Combine(Path.GetDirectoryName(Assembly.GetEntryAssembly().Location), "Example.xml");
            using (MemoryStream stream = new MemoryStream())
            {
                serializer.Serialize(stream, serializableObject);
                stream.Position = 0;
                xmlDocument.Load(stream);
                xmlDocument.Save(path);
            }
        }
    }
}
