using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonAdressProject
{
    class Project
    {
        static void Main(string[] args)
        {
            string ForenameP1 = "";

            string SurnameP1 = "";

            int AgeP1 = 0;

            Person P1 = new Person();

            Console.WriteLine("Please enter the forename");

            P1.SetOtherNames(Console.ReadLine());

            Console.WriteLine("Please enter teh surname");

            P1.SetSurname(Console.ReadLine());

            Console.WriteLine("Please enter the age");

            P1.Setage(Convert.ToInt32(Console.ReadLine()));

            //this is where you right new code^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^

            Console.ReadLine();
        }
        
    }
}

