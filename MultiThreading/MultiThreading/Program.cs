using System;
using System.Threading;

namespace MultiThreading
{
    class Program
    {
        public static void Main(string[] args)
        {
            //naming curently running thread as mainThread
            Thread mainThread = Thread.CurrentThread;
            mainThread.Name = "MainThread";
            Console.WriteLine("Main Thread executing");


            int a = 20;
            //creating new thread1
            Thread thread1 = new Thread(() => ChangeValue(out a));

            thread1.Start();

            //Since the main thread is already running, it is paused, and thread 1 begins to run.
            //thread1 executes ChangeMethod 
            Thread.Sleep(2000);


            //again main thread starts executing from here when thread 1 is paused
            Console.WriteLine("Thread 1 paused");
            Console.WriteLine("Main thread resumed ");
            Console.WriteLine("a value before changing in method:" + a);

            //Since the main thread is already running, it is paused, and thread 1 begins to run from where it stopped .
            Thread.Sleep(3000);

            Console.WriteLine("Main thread resumed ");
            Console.WriteLine("a value after changing in method:" + a);
            Console.WriteLine("Main thread completed ");
        }

        /// <summary>
        /// this method is used to change the value of the variable which is sent as parameter 
        /// </summary>
        /// <param name="tempA"></param>
        public static void ChangeValue(out int tempA)
        {
            Console.WriteLine("Main thread paused ");
            Console.WriteLine("Thread 1 started");

            //Since the thread 1 is already running, it is paused, and main thread begins to run from where it stopped.
            Thread.Sleep(2000);

            //again thread 1 start executing from here when main thread is paused
            Console.WriteLine("Main thread paused ");
            Console.WriteLine("Thread 1 resume and changes b value");

            tempA = 200;
            Console.WriteLine("Thread 1 completed");
        }
    }
}
