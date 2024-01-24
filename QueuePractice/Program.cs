using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueuePractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue Qu = new Queue(5);
            Qu.EnQueue(5);
            Qu.EnQueue(10);
            Qu.EnQueue(15);

            Qu.Printing();
            Console.WriteLine();

            Console.WriteLine("===================");
            Qu.DelQueue();
            Qu.Printing();

            Console.WriteLine("===================");
            Console.WriteLine(Qu.IsEmpty());
            Console.WriteLine("===================");
            Qu.DelQueue();
            Qu.DelQueue();
            Console.WriteLine(Qu.IsEmpty());

        }
    }
}
