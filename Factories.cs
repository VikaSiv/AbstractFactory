using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class RedFactory : IShapeFactory
    {
        public IShape CreateCircle() => new RedCircle();
        public IShape CreateSquare() => new RedSquare();
        public IShape CreateTriangle() => new RedTriangle();
    }

    public class BlueFactory : IShapeFactory
    {
        public IShape CreateCircle() => new BlueCircle();
        public IShape CreateSquare() => new BlueSquare();
        public IShape CreateTriangle() => new BlueTriangle();
    }

    public class GreenFactory : IShapeFactory
    {
        public IShape CreateCircle() => new GreenCircle();
        public IShape CreateSquare() => new GreenSquare();
        public IShape CreateTriangle() => new GreenTriangle();
    }
}
