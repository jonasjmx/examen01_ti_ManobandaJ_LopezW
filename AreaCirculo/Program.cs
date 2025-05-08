using AreaCirculo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasGeomatricasMYLC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IAreaCalculator_MYLC circle = new Circle_MYLC(5);
            IAreaCalculator_MYLC square = new Square_MYLC(4);
            var sphere = new Sphere_MYLC(3);
            var cube = new Cube_MYLC(2);

            Console.WriteLine("Círculo\nÁrea: {0:F2}\n", circle.CalculateArea_APXX());
            Console.WriteLine("Cuadrado\nÁrea: {0:F2}\n", square.CalculateArea_APXX());
            Console.WriteLine("Esfera\nÁrea: {0:F2}\nVolumen: {1:F2}\n",
                sphere.CalculateArea_APXX(), sphere.CalculateVolume_APXX());
            Console.WriteLine("Cubo\nÁrea: {0:F2}\nVolumen: {1:F2}\n",
                cube.CalculateArea_APXX(), cube.CalculateVolume_APXX());
        }
    }
}
