using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace GeometryLib.Shapes
{
    public class Triangle : IShape
    {
        public readonly double A;
        public readonly double B;
        public readonly double C;
        public Triangle(double a, double b, double c)
        {
            if(a > 0 & b > 0 & c > 0 & a + b > c & b + c > a & a + c > b){
                A = a;
                B = b;
                C = c;
            }
            else{
                throw new ArgumentException("Такой треугольник не возможен!");
            }
        }
        public bool IsRectangle{
            get{
                double[] sideTriangle = new double[] {A, B, C};
                Array.Sort(sideTriangle);
                return sideTriangle[0] * sideTriangle[0] + sideTriangle[1] * sideTriangle[1] == sideTriangle[2] * sideTriangle[2];
            }
        }
        public double GetArea()
        {
            double p = (A + B + C ) / 2;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }
    }
}