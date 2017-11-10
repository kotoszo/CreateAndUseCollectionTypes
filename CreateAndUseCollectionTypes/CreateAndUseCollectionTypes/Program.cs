﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateAndUseCollectionTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue queue = new Queue();
            queue.Enqueue("First");
            queue.Enqueue("Second");
            queue.Enqueue("Third");
            queue.Enqueue("Fourth");

            while (queue.Count > 0)
            {
                object obj = queue.Dequeue();

                Console.WriteLine("From queue : {0}", obj);
            }
            Console.WriteLine("------------------------------------------------------------------------");

            Stack stack = new Stack();
            stack.Push("First");
            stack.Push("Second");
            stack.Push("Third");
            stack.Push("Fourth");

            while (stack.Count > 0)
            {
                object obj = stack.Pop();
                Console.WriteLine("From stack: {0}", obj);
            }
            Console.WriteLine("------------------------------------------------------------------------");


        }
    }
}
