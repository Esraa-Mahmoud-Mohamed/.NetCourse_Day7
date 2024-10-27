using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    public class Line
    {
        Point p1;
        Point p2;

        public Point P1
        {
            get
            {
                return p1;
            }

            set
            {
                p1 = value;
            }
        }

        public Point P2
        {
            get
            {
                return p2;
            }

            set
            {
                p2 = value;
            }
        }

        public Line()
        {
            p1 = new Point();
            p2 = new Point();
        }

        public Line(int _x1, int _y1, int _x2, int _y2)
        {
            p1 = new Point();
            p2 = new Point();

            p1.X = _x1;
            p1.Y = _y1;
            p2.X = _x2;
            p2.Y = _y2;

        }

    }
}
