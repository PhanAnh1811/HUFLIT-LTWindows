using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_1
{
    class Point
    {
        private double x;
        private double y;

        public double getX()
        {
            return x;
        }

        public double getY()
        {
            return y;
        }

        public Point() { }

        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
    }
}
