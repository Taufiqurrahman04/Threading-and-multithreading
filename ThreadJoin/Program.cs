using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadJoin
{
    class Program
    {
        //--Thread yang akan di eksekusi sebanyak 4 kali
        static void PrintJoin()
        {
            //----Mendelay Selama 5 Second
            Thread.Sleep(5000);
        }
        //---Method mengeksekusi Thread PrintJoin Sebanyak 4 kali dengan join
        static void UseJoin()
        {
            Console.WriteLine("---------Memanggil Thread Yang Sama Dengan Menggunakan Join----------------");
            //--Array dari thread untuk menampung 4 thread
            Thread[] array = new Thread[4];
            for (int i = 0; i < array.Length; i++)
            {
                // Start the thread with a ThreadStart.
                array[i] = new Thread(new ThreadStart(PrintJoin));
                array[i].Start();
            }
            // Join all the threads.
            for (int i = 0; i < array.Length; i++)
            {
                array[i].Join();
            }
        }
        //---Memanggil Method yang sama tanpa join
        static void TanpaJoin()
        {
            Console.WriteLine("---------Memanggil Thread Yang Sama Tanpa Menggunakan Join----------------");
            int x = 4;
           
           while (x > 0)
           {
              PrintJoin();
               x--;
           }
        }
        static void Main(string[] args)
        {
            //--Menghitung waktunya dengan stopwatch
            var stopwatch = Stopwatch.StartNew();
            //--stopwatch mulai
            Console.WriteLine("Mulai : {0} ", stopwatch.ElapsedMilliseconds);
           // UseJoin();
            TanpaJoin();
            //--stopwatch selesai
            Console.WriteLine("Selesai : {0}",stopwatch.ElapsedMilliseconds);
        }
    }
}
