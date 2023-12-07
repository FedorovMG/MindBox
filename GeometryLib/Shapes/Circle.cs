using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeometryLib.Shapes
{
    public class Circle : IShape
    {
        public readonly double _radius;
        public Circle(double radius)
        {
            _radius = radius;
        }
        
        public double GetArea()
        {
            return Math.PI * _radius * _radius;
        }
    }
}