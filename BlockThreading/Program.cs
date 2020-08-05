using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BlockThreading
{
    class Program
    {
        //--Create objek lock
        private static readonly object locker = new object();
        //--Method dengan menggunakan lock
        static void PrintDone(object input)
        {
            //--Memanggil lock
            lock (locker)
            {
                //--Perintah yang akan dieksekusi atau bagian yang disebut critical area
                int x = 0;
                while (x < 100)
                {
                    Console.Write(input);
                    x++;
                }
            }
        }
        //--Method untuk thread tanpa lock
        static void WithoutLock(object input)
        {
            //--Perintah yang dieksekusi tanpa lock
            int x = 0;
            while (x < 100)
            {
                Console.Write(input);
                x++;
            }
        }
        static void TheadDenganLoc()
        {
            //--Threading dengan lock
            Console.WriteLine("---------------Threading dengan lock--------------------");
            //--Cretae new objek threading
            Thread tr = new Thread(PrintDone);
            //--panggil method start
            tr.Start("x");
            //--Thread tanpa Threading
            PrintDone("y");
        }
        static void ThreadTanpaLock()
        {
            //Threading tanpa Lock
            Console.WriteLine("---------------Threading tanpa lock--------------------");
            //--Create objek Threading
            Thread tr1 = new Thread(WithoutLock);
            //--Panggil method start
            tr1.Start("x");
            //--Thread tanpa threading
            WithoutLock("y");
        }
        static void Main(string[] args)
        {
            // TheadDenganLoc();
            ThreadTanpaLock();
            Console.ReadLine();
        }
    }
}
