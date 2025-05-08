using FigurasGeomatricasMYLC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCirculo
{
    public class Circle_MYLC : IAreaCalculator_MYLC
    {
        private double _radius;
        public Circle_MYLC(double radius) => _radius = radius;

        public double CalculateArea_MYLC() => Math.PI * _radius * _radius;
    }

    public class Square_MYLC : IAreaCalculator_MYLC
    {
        private double _side;
        public Square_MYLC(double side) => _side = side;

        public double CalculateArea_MYLC() => _side * _side;
    }

    // Implementación de la interfaz esfera para calcular área y volumen
    public class Sphere_MYLC : IAreaCalculator_MYLC, IVolumeCalculator_MYLC
    {
        private double _radius;
        // Constructor que recibe el radio de la esfera
        public Sphere_MYLC(double radius) => _radius = radius;

        // Implementación de los métodos para calcular área y volumen
        public double CalculateArea_MYLC() => 4 * Math.PI * _radius * _radius;
        public double CalculateVolume_MYLC() => (4.0 / 3.0) * Math.PI * Math.Pow(_radius, 3);
    }

    // Implementación de la interfaz cubo para calcular área y volumen
    public class Cube_MYLC : IAreaCalculator_MYLC, IVolumeCalculator_MYLC
    {
        private double _side;
        // Constructor que recibe el lado del cubo
        public Cube_MYLC(double side) => _side = side;

        // Implementación de los métodos para calcular área y volumen
        public double CalculateArea_MYLC() => 6 * _side * _side;
        public double CalculateVolume_MYLC() => _side * _side * _side;
    }
}
