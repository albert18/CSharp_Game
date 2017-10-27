using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication.Model
{
    class Rectangle
    {
        private int length;
        private int width;

        public Rectangle()
        {
            Console.WriteLine("We are in the rectangle Contrutor");
            length = 0;
            width = 0;
        }

        public Rectangle(int sideA, int sideB)
        {
            Console.WriteLine("This contruction take to the values!");
            length = sideA;
            width = sideB;
        }

        public int GetArea()
        {
            return length = width;
        }



    }
}


            //Rectangle r = new Rectangle();
            //Console.WriteLine("{0}", r.GetArea());

            //Rectangle r2 = new Rectangle(5, 10);
            //Console.WriteLine("Area: {0}", r2.GetArea());
            //Console.ReadLine();

