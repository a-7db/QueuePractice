using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueuePractice
{
    internal class Queue
    {
        public int[] arry;
        public int First;
        public int End;
        public int count;

        public Queue(int size)
        {
            arry = new int[size];
            First = 0;
            End = 0;
            count = 0;
        }

        public void EnQueue(int Data)
        {
            arry[End] = Data;
            End++;
            count++;
        }

        public int DelQueue()
        {
            if (count == 0)
            {
                Console.WriteLine("You don't have data..");
                return 0;
            }
            else
            {
                int temp = First;
                First++;
                count--;
                return temp;
            }
        }


        public void Printing()
        {
            int temp = First;
            for (int i = temp; i < count; i++)
            {
                temp++;
                Console.WriteLine(arry[i]);
            }
        }

        public bool IsEmpty()
        {
            if (count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
