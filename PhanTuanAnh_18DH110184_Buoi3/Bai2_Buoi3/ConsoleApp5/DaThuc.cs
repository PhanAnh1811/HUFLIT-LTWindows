using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class DaThuc
    {
        private List<DonThuc> daThuc;

        public DonThuc this[int i] { get => daThuc[i]; }

        public DaThuc()
        {
            daThuc = new List<DonThuc>();
        }
        
        public DaThuc(List<DonThuc> list)
        {
            daThuc = list;
        }

        public void Input()
        {
            while (!false)
            {
                DonThuc donThuc = new DonThuc();
                donThuc.InPut();
                daThuc.Add(donThuc);
                Console.WriteLine("Them don thuc thanh cong");
                Console.Write("Ban co muon nhap tiep? nhan y tu ban phim: ");
                string pick = Console.ReadLine();
                if (pick != "y")
                    break;                
            }
        }

        public override string ToString()
        {
            string res = "";
            foreach (DonThuc pointer in daThuc)
                res += pointer.ToString() + " + ";
            string s = res.Remove(res.Length - 2);
            return s;
        }

        public double Result(double x)
        {
            double res = 0;
            foreach(DonThuc pointer in daThuc)
            {
                res += pointer.Result();
            }
            return res;
        }
    }
}
