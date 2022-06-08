using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegateMultiCast
{
    class SingleCast
    {
        public delegate void singledelegate(int no1, int no2);
        //static void Main(string[] args)
        //{
        //    SingleCast single = new SingleCast();
        //    singledelegate del = new singledelegate(single.sum); //initiating a delegate--we only send the name of the method.
        //    del(4,5);
        //    Console.ReadKey();
        //}
        public void sum(int a,int b)
        {
            int s = a + b;
            Console.WriteLine("the sum is :"+ s);
        }
    }
}
