using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assign1
{
    internal class assignQ5
    {
        static void Main(
            )
        {
            double r, AREA;

            double PI = 3.14;

            Console.WriteLine("area and circumference circle");

            Console.Write("\nEnter the radius of circle ");
            r = Convert.ToDouble(Console.ReadLine());
            AREA = PI * r * r;
            Console.WriteLine("\nThe area of circle is {0} when radius is {1}", AREA, r);
            Console.WriteLine("\nThe circumference of circle is {0}", 2 * PI * r);
            Console.ReadKey();


        }
    }
}

    

