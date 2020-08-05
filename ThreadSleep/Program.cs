using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadSleep
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("-----------Dengan Thread Sleep Selama 5 detik------------");
            Console.WriteLine("{0}", DateTime.Now.Second.ToString());
            //--Thread Sleep dalam 5 second = 5000 milisecond
            Thread.Sleep(5000);
            Console.WriteLine("{0}", DateTime.Now.Second.ToString());
            Console.WriteLine("-----------Tanpa Thread Sleep----------------------------");
            Console.WriteLine("{0}", DateTime.Now.Second.ToString());
            Console.WriteLine("{0}", DateTime.Now.Second.ToString());
        }
    }
}
