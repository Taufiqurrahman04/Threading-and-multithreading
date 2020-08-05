using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncrounousDelegate
{
    class Program
    {
        delegate string AsyncrounousDelegate(int number, out int threadId);

        static string Pangkat(int number,out int threadId)
        {
            Console.WriteLine("Memangkatkan {0} dengan pangkat 5 : ", number);
            threadId = Thread.CurrentThread.ManagedThreadId;
            return "Hasil nya adalah " + Math.Pow(number, 5);
        }
        static void Main(string[] args)
        {
            int threadId;
            //--Create objek delegate
            AsyncrounousDelegate delegeMethod = new AsyncrounousDelegate(Pangkat);
            //--BeginInvoke
            IAsyncResult outputBeginInvoke = delegeMethod.BeginInvoke(135,out threadId, null, null);
            //--End Invoke
            string result = delegeMethod.EndInvoke(out threadId, outputBeginInvoke);
            //--Print return value
            Console.WriteLine(result);
        }
    }
}
