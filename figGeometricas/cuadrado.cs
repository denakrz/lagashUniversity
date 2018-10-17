using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShapes
{
    class Square : Shapes
    {
        public override void CalculateArea(int x, int y)
        {
            Console.WriteLine("El área del cuadrado con altura {0} y base {1} es igual a {2}.", x, y, (x * y));
        }
    }
}
