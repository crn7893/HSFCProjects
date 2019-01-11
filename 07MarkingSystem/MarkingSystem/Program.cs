using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarkingSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            int Count = 0;
            string[] nameStudent  =new string[99];
            int[] Marks = new int[99];
            Console.WriteLine("Welcome to the mark averaginator 9000"); // very 1990's style name
            
            

            while (nameStudent[Count] != nameStudent[99])
            {
                Console.WriteLine("Enter names and marks of student. when you have finished type <Stop> (CaSe SeNsItIvE)/n Name:");
                nameStudent[Count] =(Console.ReadLine());
                Console.WriteLine("Please enter {0}'s mark:", nameStudent[Count]);
                Marks[Count] = Convert.ToInt32(Console.ReadLine());

                Count++;
                
                if (Console.ReadLine() == "stop")
                {
                    nameStudent[Count] = nameStudent[99];
                }
            }

            //^^^^^^^^^^^^^^^^^^^^^^^code-above-here^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
            Console.ReadLine();
        }
    }
}
