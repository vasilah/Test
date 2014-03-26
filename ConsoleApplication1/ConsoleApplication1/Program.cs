using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("123");

            throw new Exception("new");

            throw new Exception("Мега фича 2");
        }
    }
}
