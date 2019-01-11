using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackProject
{
    class Program
    {
        static void Main(string[] args)
        {
            stackClass MyStack = new stackClass();

            

            for (int i = 0; i > 10; i++) ;
            {
                Console.WriteLine("Please enter a Name ");

                MyStack.Push(Console.ReadLine());
                
                
            }
            Console.ReadLine();
        }
    }
}
