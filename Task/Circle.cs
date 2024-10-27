using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    public class Circle
    {
        Point center;
        int radius;

        public Point Center
        {
            get
            {
                return center;
            }

            set
            {
                center = value;
            }
        }

        public int Radius
        {
            get
            {
                return radius;
            }

            set
            {
                radius = value;
            }
        }

        public Circle()
        {
            center=new Point();
            radius=0;
        }
        public Circle(Point _center,int _radius)
        {
            center = _center;
            radius = _radius;
        }
    }
}
