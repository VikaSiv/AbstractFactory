using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class BlueCircle : IShape
    {
        public void Draw(Graphics g)
        {
            g.FillEllipse(Brushes.Blue, 10, 10, 100, 100);
        }
    }

    public class BlueSquare : IShape
    {
        public void Draw(Graphics g)
        {
            g.FillRectangle(Brushes.Blue, 120, 10, 100, 100);
        }
    }

    public class BlueTriangle : IShape
    {
        public void Draw(Graphics g)
        {
            Point[] points = { new Point(230, 110), new Point(280, 10), new Point(330, 110) };
            g.FillPolygon(Brushes.Blue, points);
        }
    }
}
