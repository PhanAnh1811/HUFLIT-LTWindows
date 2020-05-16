using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    class Songuyento
    {
        public int n;

        public Songuyento(int n)
        {
            this.n = n;
        }

        public bool CheckNT()
        {
            if (n <= 1)
                return false;
            else
            {
                for (int i = 2; i < n; i++)
                {
                    if (n % i == 0)
                        return false;
                }
            }
            return true;
        }
    }
}
