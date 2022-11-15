using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assign1
{
    internal class AssignQ6
    { 

    static void Main(string[] args)
    {
        Console.WriteLine("--------SELECT OPTION----------");


        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Press 1 for Magazine");
        Console.WriteLine("Press 2 for Novel");
        Console.WriteLine("Press 3 for ReferenceBook");
        Console.WriteLine("Press 4 for Miscellaneous \n");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Enter ur option: ");


        int action = Convert.ToInt32(Console.ReadLine());

        switch (action)
        {
            case 1:

                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Book_Id:1");
                    Console.WriteLine("Title: Hindu");
                    Console.WriteLine("Price: 400");
                    Console.WriteLine("Book Type: Magazine");


                    break;
                }
            case 2:
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Book_Id:2");
                    Console.WriteLine("Title:True friend");
                    Console.WriteLine("Price: 250");
                    Console.WriteLine("Book Type: Novel");
                    break;
                }
            case 3:
                {
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine("Book_Id:3");
                    Console.WriteLine("Title:ramayanam");
                    Console.WriteLine("Price: 950");
                    Console.WriteLine("Book Type: ReferenceBook");
                    break;
                }
            case 4:
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Book_Id:4");
                    Console.WriteLine("Title: crack ");
                    Console.WriteLine("Price: 400");
                    Console.WriteLine("Book Type: Miscellaneous");
                    break;
                }
            default:
                Console.WriteLine("Incorrect option");
                break;
        }

        Console.ReadKey();
    }


}
}




