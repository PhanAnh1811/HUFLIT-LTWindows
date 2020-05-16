using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class ListPhanSo
    {
        private List<PhanSo> listPs;

        public ListPhanSo()
        {
            listPs = new List<PhanSo>();
        }

        public ListPhanSo(List<PhanSo> mPs)
        {
            listPs = mPs;
        }

        public void addPs()
        {
            while (!false)
            {
                PhanSo ps = new PhanSo();
                ps.Nhap();
                listPs.Add(ps);
                Console.WriteLine("Them phan so thanh cong");
                Console.Write("Ban co muon nhap tiep? nhan y tu ban phim: ");
                string pick = Console.ReadLine();
                if (pick != "y")
                    break;
            }
        }

        public void OutPut()
        {
            foreach(var x in listPs)
            {
                Console.WriteLine(x.ToString());
            }
        }

        public double SumPs()
        {
            double result = 0;
            foreach (var x in listPs)
            {
                result += x.GiaTriThapPhan();
            }
            return result;
        }
    }
}

