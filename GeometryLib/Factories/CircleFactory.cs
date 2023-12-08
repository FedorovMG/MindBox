using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GeometryLib.Shapes;

namespace GeometryLib.Factories
{
    public class CircleFactory : ShapeFactory
    {
        public double Radius { get; set; }
        public CircleFactory(double radius)
        {
            Radius = radius;
        }
        public override Circle GetShape(){
            if (Radius > 0)
            {
                return new Circle(Radius);
            }
            else
            {
                return null;
            }
        }
    }
}