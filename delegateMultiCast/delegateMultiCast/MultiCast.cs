using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegateMultiCast
{
    class MultiCast
    {
        public delegate void multidelegate(int no1, int no2);
        public void sum (int a,int b)
        {
            int s = a + b;
            Console.WriteLine("the sum is :"+ s);
        }
        public void dif(int a,int b)
        {
            int s = a - b;
            Console.WriteLine("the difference is:"+ s);
        }
        public static void multi(int a,int b)
        {
            int s = a * b;
            Console.WriteLine("the multiply is:"+ s);
        }
        //static void Main(string[] args)
        //{
        //    MultiCast m = new MultiCast();
        //    multidelegate del = new multidelegate(m.sum);
        //    del =  del + m.dif;
            
        //    del(5, 4);
        //    Console.WriteLine();
        //    del = del - m.sum;
        //    del(9,4);
        //    Console.WriteLine();
        //    del += MultiCast.multi;
        //    del(10,2);
        //    Console.ReadKey();
        //}

    }
}
