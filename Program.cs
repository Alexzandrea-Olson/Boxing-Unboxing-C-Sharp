// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boxing
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables
            int x = 12;
            double y = 12.5;
            String name = "Hannah";

            //Boxing
            object obj1 = x;
            object obj2 = y;
            object obj3 = name;

            //unboxing 
            int x1 = (Int32)obj1;
            double y1 = (Double)obj2;
            string x2 = (String)obj3;

            Console.WriteLine(x1);
            Console.WriteLine(y1);
            Console.WriteLine(x2);
        }
    }
}