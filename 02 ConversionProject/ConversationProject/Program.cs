using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversationProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Conversion myConvert = new Conversion();
            string UserString = "";
            // have a loop with menu
            Console.WriteLine("Welcome \n Please enter 1 for Reversals\n ");
            Console.WriteLine(" Please enter 2 for Kilometers to Miles conversion \");");
            Console.WriteLine("Please enter 3 for Miles to Kilometers conversion");
            Console.WriteLine("Enter q to quit");
            // include a switch statement 
            String option = Console.ReadLine();

            while (option != "q")
            {
                switch (option)
                {
                    case "1":
                        Console.WriteLine("Please enter your string");

                        UserString = Console.ReadLine();
                        string Kilometers = ("");

                        break;

                    case "2":

                        Console.WriteLine("Please enter the number of kilometers");

                        Console.ReadLine();

                        Console.WriteLine("The number of miles is {0}", Kilometers * 1.609);

                        break;

                    default:

                        Console.WriteLine("unknown input");

                        break;
                }
            }

        }
    }
}
