using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assign1
{
    internal class assignQ4
    {
        static void Main(string[] args)
        {
            int num1, num2, temp;
           
            Console.WriteLine("enter first integer");
           
            num1 = int.Parse(Console.ReadLine());
           
            Console.WriteLine("enter second integer");
            
            num2 = int.Parse(Console.ReadLine());
            temp = num1;
            num1 = num2;
            num2 = temp;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("After Swapping : ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("\n First integer : " + num1);
            Console.Write("\n Second integer : " + num2);
            Console.Read();




        }
    }
}

    

