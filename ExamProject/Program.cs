﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamProject
{
    class Program
    {
        static void Main(string[] args)
        {
           /* LinkedList<string> myList = new LinkedList<string>();
            myList.AddFirst("C");
            myList.AddFirst("B");
            myList.AddFirst("A");
            myList.AddLast("D");
            myList.AddLast("E");
            myList.Print();
            Console.WriteLine("------");
            myList.RemoveFirst();
            myList.Print();
            Console.WriteLine("------");
            myList.RemoveLast();
            myList.Print();
            Console.WriteLine("------");
            string s = "D";
            if (myList.Find(s)) Console.WriteLine("{0} exists", s);
            else Console.WriteLine("{0} doesn't exist", s);
            Console.WriteLine("------");
            Console.WriteLine("Lenght of list is {0}", myList.Lenght());
            Console.WriteLine("------");
            myList.Remove("A");
            myList.Print();
            Console.WriteLine("------");
            */
            LinkedList<int> myList2 = new LinkedList<int>();
            myList2.AddFirst(1);
            myList2.AddFirst(4);
            myList2.AddFirst(3);
            myList2.AddFirst(0);
            myList2.AddFirst(2);
            myList2.AddFirst(5);
            myList2.Print();
            myList2.Sort();
            Console.WriteLine("-------------");           
            myList2.Print();

            Console.ReadKey();
        }
    }
}
