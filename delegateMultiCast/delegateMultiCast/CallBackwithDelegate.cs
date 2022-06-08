using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegateMultiCast
{
    public delegate void callbacktask(int i);
    class CallBackwithDelegate
    {
        static void Main(string[] args)
        {
            task t = new task();
            callbacktask call = new callbacktask(callbackfunction);
            call = call + callbackfunction2;
            t.performtask(call);
            Console.ReadKey();
        }
        public static void callbackfunction(int i)
        {
            Console.WriteLine("here "+i);
        }
        public static void callbackfunction2(int i)
        {
            Console.WriteLine("here toooo" + i);
        }
    }
    class task
    {
        public void performtask(callbacktask callbacktask)
        {
            for(int i=0;i<10000000;i++)
            {
                //this function is doing a lot of task...our objective is doing a callback in between doing all these task
                //that is in between printing all this no ...control will go to callback function
                Console.WriteLine(i);
                callbacktask(i);
            }
        }
    }
}
