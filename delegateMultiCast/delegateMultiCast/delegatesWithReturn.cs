using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegateMultiCast
{
    class delegatesWithReturn
    {
        public delegate int multicastwithReturn(int a,int b);
        public static int sum(int a,int b)
        {
            int s = a + b;
            return s;
        }
        public static int multi(int a,int b)
        {
            int s = a * b;
            return s;
        }
        //static void Main(string[] args)
        //{
        //    multicastwithReturn del = new multicastwithReturn(delegatesWithReturn.sum);
        //    del = del + delegatesWithReturn.multi;
        //    int a = del(9,4);
        //    Console.WriteLine(a);
        //    Console.ReadKey();
        //}
    }
}
