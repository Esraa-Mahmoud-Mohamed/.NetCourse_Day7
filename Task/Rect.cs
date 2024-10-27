using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    public class Rect
    {
        Point ul;
        Point lr;


        public Point Ul
        {
            get
            {
                return ul;
            }

            set
            {
                ul = value;
            }
        }

        public Point Lr
        {
            get
            {
                return lr;
            }

            set
            {
                lr = value;
            }
        }

        public Rect()
        {
            ul = new Point();
            lr = new Point();
        }
        public Rect(int x1, int y1, int x2, int y2)
        {
            ul = new Point(x1, y1);
            lr = new Point(x2, y2);
        }
    }
}
