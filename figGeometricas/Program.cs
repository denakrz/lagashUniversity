using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShapes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shapes> areas = new List<Shapes>();
            areas.Add(new Square());
            areas.Add(new Triangle());

            Console.WriteLine("Ingrese la altura.");
            int x = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la base.");
            int y = Int32.Parse(Console.ReadLine());


            foreach (Shapes items in areas)
            {
                items.CalculateArea(x, y);
            }

            Console.Read();
        }
    }
}