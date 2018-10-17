using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();
            animals.Add(new Dog());
            animals.Add(new Cat());
            foreach (Animal item in animals)
            {
                Console.WriteLine(item.MakeSound());
            }
            Console.ReadKey();
        }
    }
}
    

