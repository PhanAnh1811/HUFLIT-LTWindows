using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Mang1chieu
    {
        private int[] array = new int[100];
        private int n = 100;

        public int this[int i]
        {
            get { return array[i]; }
            set { array[i] = value; }
        }

        public Mang1chieu() { }

        public Mang1chieu(int n)
        {            
            array = new int[n];
            this.n = n;
        }
        
        public Mang1chieu(Mang1chieu TempArray)
        {
            array = new int[TempArray.n];
            for(int i = 0; i < TempArray.n; i++)
            {
                array[i] = TempArray.array[i];
            }
        }
        public void InPut()
        {
            Console.Write("Nhap so luong phan tu cua mang: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("-----------------------------------");

            array = new int[num];
            n = num;

            for (int i = 0; i < n; i++)
            {
                Console.Write("Nhap phan tu thu {0}: A[{1}]= " ,i+1,i);
                array[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("-----------------------------------");
        }

        public void TimSoChan()
        {
            Console.WriteLine("-------------------------------");
            Console.Write("So chan co trong mang la: ");
            for(int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                    Console.Write(" {0} ", array[i]);                
            }           
        }

        public void OutPut()
        {
            Console.Write("Phan tu mang 1 chieu:");
            for(int i = 0; i < array.Length; i++)
            {
                Console.Write(" {0} ",array[i]);
            }
            Console.WriteLine();
        }
    }
}
