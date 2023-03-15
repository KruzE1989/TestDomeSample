using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TestDomeSolutions
{
    public class CeramicStore
    {
        public static void RunAndWait(Action[] actions)
        {
            //List<Task> task = new();
            //foreach (var item in actions)
            //{
            //    task.Add(Task.Factory.StartNew(item));
            //}
            //Task.WaitAll(task.ToArray());
            List<Thread> threads = new List<Thread>();
            foreach (Action action in actions)
            {
                var thread = new Thread(new ThreadStart(action));
                thread.Start();
                threads.Add(thread);
            }
            threads.ForEach(x => x.Join());
        }

        public static void Main(string[] args)
        {
            var actions = new Action[]
            {
            () => {
                Thread.Sleep(800);
                Console.WriteLine("Slow function");
            },
            () => {
                Thread.Sleep(100);
                Console.WriteLine("Fast function");
            }
            };
            // Expected output:
            // Fast function
            // Slow function
            // Returned from the method!
            RunAndWait(actions);
            Console.WriteLine("Returned from the method!");
        }
    }
}
