using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _01_HelloWorld
{
    class MyThread
    {

        public void InfoThread()
        {
            Thread th = Thread.CurrentThread;
            th.Name = "MainThread";
            Console.WriteLine("thread name: {0}", th.Name);
            Console.WriteLine("currentCulture: {0}", th.CurrentCulture);
            Console.WriteLine("executionContext: {0}", th.ExecutionContext);
            Console.WriteLine("isAlive: {0}", th.IsAlive);
            Console.WriteLine("isBackground: {0}", th.IsBackground);
            Console.WriteLine("ThreadState: {0}", th.ThreadState);
            Console.WriteLine("priority: {0}", th.Priority);
            Console.ReadKey();
        }

        public static void ChildCall()
        {
            Console.WriteLine("inside child");
            Thread th = Thread.CurrentThread;
            Console.ReadKey();
            Console.WriteLine("inside child");
        }

        public Thread NewThread()
        {
            ThreadStart child = new ThreadStart(ChildCall);
            Console.WriteLine("new Thread");
            Thread childThread = new Thread(child);
            childThread.Start();
            return childThread;
        }
    }
}
