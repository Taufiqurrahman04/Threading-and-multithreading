using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadPool.QueueUserWorkItem
{
    class Program
    {
        
        static void methodTest(object d)
        {
            Console.WriteLine("Thread {0}",(int)d);
        }
        static void Main(string[] args)
        {
            var reset = new ManualResetEvent(false);
            for(int x = 0; x < 10; x++)
            {
                System.Threading.ThreadPool.QueueUserWorkItem(new WaitCallback( methodTest), x);
            }
            Thread.Sleep(100);
            Console.Write("Press Enter To Reset Thread Pool ? ");
            Console.ReadLine();
            reset.Set();
        }
    }
}
