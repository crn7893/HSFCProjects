using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProject
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] UserNumber;

            Console.WriteLine("Please press enter to continue");

            UserNumber = new int[20];

            for (int Count = 0; Count < UserNumber.Length; Count++)
            {
                Console.WriteLine("Please enter a number");

                UserNumber[Count] = Convert.ToInt32(Console.ReadLine());

            }


            Console.WriteLine("This is you number reversed\n" + for (int Count = 20; Count <UserNumber.Length-1; Count--);

            Console.ReadLine();
        }
    }
}
