using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GeometryLib.Shapes;

namespace GeometryLib.Factories
{
    public class TriangleFactory : ShapeFactory
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }
        public TriangleFactory(double a, double b, double c)
        {
            A = a; B = b; C = c;
        }
        public override Triangle GetShape()
        {
            if (A > 0 & B > 0 & C > 0 & A + B > C & A + C > B & B + C > A)
            {
                return new Triangle(A, B, C);
            }
            else
            {
                return null;
            }
        }
    }
}