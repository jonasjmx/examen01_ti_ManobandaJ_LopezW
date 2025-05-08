using FigurasGeomatricasMYLC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCirculo
{
    public class Circle_APXX : IAreaCalculator_MYLC
    {
        private double _radius;
        public Circle_APXX(double radius) => _radius = radius;

        public double CalculateArea_APXX() => Math.PI * _radius * _radius;
    }

    public class Square_APXX : IAreaCalculator_MYLC
    {
        private double _side;
        public Square_APXX(double side) => _side = side;

        public double CalculateArea_APXX() => _side * _side;
    }

    public class Sphere_APXX : IAreaCalculator_MYLC, IVolumeCalculator_MYLC
    {
        private double _radius;
        public Sphere_APXX(double radius) => _radius = radius;

        public double CalculateArea_APXX() => 4 * Math.PI * _radius * _radius;
        public double CalculateVolume_APXX() => (4.0 / 3.0) * Math.PI * Math.Pow(_radius, 3);
    }

    public class Cube_APXX : IAreaCalculator_MYLC, IVolumeCalculator_MYLC
    {
        private double _side;
        public Cube_APXX(double side) => _side = side;

        public double CalculateArea_APXX() => 6 * _side * _side;
        public double CalculateVolume_APXX() => _side * _side * _side;
    }
}
