    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace AbstractFactory
    {
        public class RedCircle : IShape
        {
            public void Draw(Graphics g)
            {
                g.FillEllipse(Brushes.Red, 10, 10, 100, 100);
            }
        }

        public class RedSquare : IShape
        {
            public void Draw(Graphics g)
            {
                g.FillRectangle(Brushes.Red, 120, 10, 100, 100);
            }
        }

        public class RedTriangle : IShape
        {
            public void Draw(Graphics g)
            {
                Point[] points = { new Point(230, 110), new Point(280, 10), new Point(330, 110) };
                g.FillPolygon(Brushes.Red, points);
            }
        }
    }
