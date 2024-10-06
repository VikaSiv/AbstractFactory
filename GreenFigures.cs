using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class GreenCircle : IShape
    {
        public void Draw(Graphics g)
        {
            g.FillEllipse(Brushes.Green, 10, 10, 100, 100);
        }
    }

    public class GreenSquare : IShape
    {
        public void Draw(Graphics g)
        {
            g.FillRectangle(Brushes.Green, 120, 10, 100, 100);
        }
    }

    public class GreenTriangle : IShape
    {
        public void Draw(Graphics g)
        {
            Point[] points = { new Point(230, 110), new Point(280, 10), new Point(330, 110) };
            g.FillPolygon(Brushes.Green, points);
        }
    }
}
