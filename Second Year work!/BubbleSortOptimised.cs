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
            int TempArrayVal = 0;
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
                for (int i = 0; i < Array.Length ; i++)//this states that "passes" are taking place
                {
                    for (int j = i + 1; i+1 < Array.Length - 1; i++)//
                    {
                        TempArrayVal = Array[i];
                        Array[j] = Array[i];
                        Array[j] = TempArrayVal;
                    }
                    
                }
                isSwapped = false;
            }
            //Console.WriteLine("" + Array[0]+Array[1]+Array[2]+Array[3]+Array[4]+Array[5]+Array[6]+Array[7]+Array[8]+Array[9]+Array[10]);
            Console.WriteLine("" + Array[]);
            Console.ReadLine();
        }
    }
}
