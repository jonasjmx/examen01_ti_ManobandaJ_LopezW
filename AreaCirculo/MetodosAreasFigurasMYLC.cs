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

        public double CalculateArea_APXX() => Math.PI * _radius * _radius;
    }

    public class Square_MYLC : IAreaCalculator_MYLC
    {
        private double _side;
        public Square_MYLC(double side) => _side = side;

        public double CalculateArea_APXX() => _side * _side;
    }

    public class Sphere_MYLC : IAreaCalculator_MYLC, IVolumeCalculator_MYLC
    {
        private double _radius;
        public Sphere_MYLC(double radius) => _radius = radius;

        public double CalculateArea_APXX() => 4 * Math.PI * _radius * _radius;
        public double CalculateVolume_APXX() => (4.0 / 3.0) * Math.PI * Math.Pow(_radius, 3);
    }

    public class Cube_MYLC : IAreaCalculator_MYLC, IVolumeCalculator_MYLC
    {
        private double _side;
        public Cube_MYLC(double side) => _side = side;

        public double CalculateArea_APXX() => 6 * _side * _side;
        public double CalculateVolume_APXX() => _side * _side * _side;
    }
}
