using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeometryLib.Shapes
{
    public class Circle : IShape
    {
        private double _radius;
        public double Radius => _radius;
        public Circle(double radius)
        {
            _radius = radius;
        }
        
        public double GetArea()
        {
            return Math.PI * Radius * Radius;
        }
    }
}