using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_1
{
    class Vector
    {
        Point A;
        Point B;
        double x, y;

        public double getX()
        {
            return x;
        }

        public double getY()
        {
            return y;
        }

        public Vector(Point A,Point B)
        {
            this.A = A;
            this.B = B;
            x = this.B.getX() - this.A.getX();
            y = this.B.getY() - this.A.getY();
        }

        public double Distance()
        {
            double dis = Math.Sqrt(x * x + y * y);
            return dis;
        }
    }
}
