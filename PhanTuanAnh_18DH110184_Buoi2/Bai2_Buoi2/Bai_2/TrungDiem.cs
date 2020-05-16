using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_2
{
    class TrungDiem
    {
        Point A, B;
        double x, y;

        public double getX()
        {
            return x;
        }

        public double getY()
        {
            return y;
        }
        public TrungDiem(Point A, Point B)
        {
            this.A = A;
            this.B = B;
        }
        public Point TD()
        {
            x = (this.A.getX() + this.B.getX())/2;
            y = (this.A.getY() + this.B.getY())/2;
            Point I = new Point(x,y);
            return I;
        }
    }
}
