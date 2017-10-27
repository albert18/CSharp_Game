using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication.Model
{
    class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }

        public decimal Add(decimal a, decimal b)
        {
            return a + b;
        }

    }
}


            //Calculator c = new Calculator();

            //Console.WriteLine("{0}", c.Add(1, 2));

            //Console.WriteLine("{0}", c.Add(1, 2, 3));

            //Console.ReadLine();