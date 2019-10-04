using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptimisedBubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isSwapped = true;
            int[] Array = new int[10]; //Array code found @ ' https://www.c-sharpcorner.com/UploadFile/3d39b4/bubble-sort-in-C-Sharp/ '
            // literally got Jade to help with specifying array length ;-; not good enough, must learn how to initialise arrays
            //https://www.geeksforgeeks.org/c-sharp-arrays/ helps with lots of array stuff
            Console.WriteLine("Please enter 10 numbers, one at a time. \nYou will be notified when to do so, press enter to continue.\nPlease only enter numbers, as it will crash the script if they are other types.");
            Console.ReadLine();
            for (int i = 0; i < 10; i++) // <<<<declaring i in the loop makes life SO much easier, do this<<<<
            {
                Console.WriteLine("Please enter a value for the Array");
                
                Array[i] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("You have entered " + Array[i]); //danke again
                Console.ReadLine();
            }
            while (isSwapped == true)
            {
               // for (int i = 0; i < 10; i++)//Apparently can get array lenght and out in place of "i < 10" so will try that
                {
                    //for (int j = 0; j < 10; j++)
                    {

                    }
                }
                for (int i = 0; i < Array.Length - 1; i++)
                {
                    for (int i = 0 + 1; i+1 < Array.Length - 1; i++)
                    {
                        Array[i] =
                    }
                        
                }
            }

        }
    }
}
