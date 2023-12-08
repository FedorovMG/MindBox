using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GeometryLib.Shapes;

namespace GeometryLib.Factories
{
    public abstract class ShapeFactory
    {
        public abstract IShape GetShape();
    }
}