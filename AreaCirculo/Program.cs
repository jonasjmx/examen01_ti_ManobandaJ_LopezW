using AreaCirculo;
using System;

namespace FigurasGeomatricasMYLC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crear instancia del círculo
            IAreaCalculator_MYLC circle = new Circle_MYLC(5);
            // Crear instancia del cuadrado
            IAreaCalculator_MYLC square = new Square_MYLC(4);
            // Crear instancia de la esfera
            var sphere = new Sphere_MYLC(3);
            // Crear instancia del cubo
            var cube = new Cube_MYLC(2);

            // Calcular y mostrar el área del círculo
            Console.WriteLine("Círculo\nÁrea: {0:F2}\n", circle.CalculateArea_MYLC());
            // Calcular y mostrar el área del cuadrado
            Console.WriteLine("Cuadrado\nÁrea: {0:F2}\n", square.CalculateArea_MYLC());

            // Calcular y mostrar el área y volumen de la esfera
            Console.WriteLine("Esfera\nÁrea: {0:F2}\nVolumen: {1:F2}\n",
                sphere.CalculateArea_MYLC(), sphere.CalculateVolume_MYLC());

            // Calcular y mostrar el área y volumen del cubo
            Console.WriteLine("Cubo\nÁrea: {0:F2}\nVolumen: {1:F2}\n",
                cube.CalculateArea_MYLC(), cube.CalculateVolume_MYLC());
        }
    }
}
