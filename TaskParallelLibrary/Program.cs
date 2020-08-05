using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TaskParallelLibrary
{
    class Program
    {
        static void Run()
        {
            Thread.Sleep(10000);
        }
        static void UseTPL()
        {
            var stopwacth = Stopwatch.StartNew();
            Console.WriteLine("Mulai : {0} ", stopwacth.ElapsedMilliseconds);
            //--Memanggil Class Parallel Untuk Sekali Looping
            Parallel.For(0, 4, x => Run());
            Console.WriteLine("Finish : {0} ", stopwacth.ElapsedMilliseconds);
            
        }
        
        static void Main(string[] args)
        {
            UseTPL();
            Console.ReadLine();
        }
    }
}
