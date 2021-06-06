using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
//using System.Diagnostics;

namespace C_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            var th = new Thread(ExecuteInForeground);　//Threadクラスの生成
            th.Start(); //Threadの開始
            Thread.Sleep(1000); //1秒待機
            Console.WriteLine("Main thread({0}) exiting...",
                                Thread.CurrentThread.ManagedThreadId);
        }
        private static void ExecuteInForeground()
        {
            var sw = System.Diagnostics.Stopwatch.StartNew();
            Console.WriteLine("Thread{0}: {1}, Priority{2}",
                               Thread.CurrentThread.ManagedThreadId,
                               Thread.CurrentThread.ThreadState,
                               Thread.CurrentThread.Priority);
            do
            {
                Console.WriteLine("Thread {0}: Elapsed {1:N2} seconds",
                                  Thread.CurrentThread.ManagedThreadId,
                                  sw.ElapsedMilliseconds / 1000.0);
                Thread.Sleep(500);
            } while (sw.ElapsedMilliseconds <= 5000);
            sw.Stop();
        }
    }
}
