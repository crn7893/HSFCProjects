using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRegistrationGeneratorPost2001
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string Answer = "";

            

            int CarRegMin = 2001;

            string CarReg = "";

            bool checkrules (string CarReg)
            {
                bool success = true;

                char letter = CarReg[0];

                if (((letter ==  'I') | (letter == 'Q')|(letter == 'Z')) | ((letter < 'A') | (letter > 'z')))
                     
                {
                    Console.WriteLine("Fatal error detcted; False character conatained");
                    success = false;
                }

                letter = CarReg[1];

                if (((letter == 'I') | (letter == 'Q') | (letter == 'Z')) | ((letter < 'A') | (letter > 'z')))

                {
                    Console.WriteLine("Fatal error detected; False character contained");
                    success = false;
                }

                letter = CarReg[2];
                if ((letter < '0') | (letter > '9'))
                {

                    Console.WriteLine("Fatal error detected; False character contained");
                    success = false;
                }

                letter = CarReg[3];
                if ((letter < '0') | (letter > '9'))
                {

                    Console.WriteLine("Fatal error detected; False character contained");
                    success = false;
                }

                return checkrules;

            }

            Console.WriteLine("Do you have a current registration plate? \nPlease enter Y for yes and N for no");

            Answer = Console.ReadLine();
            
            switch (Answer)
            {
                case "Y":

                    Console.WriteLine("When was the car registered?");

                    

                        if (Convert.ToInt32(Console.ReadLine()) <= CarRegMin)
                    {

                        Console.WriteLine("Fatal Error detected, please restart and enter a valid value (Post 2001)");
                    }
                        else
                    {
                        Console.WriteLine("Please wait, Generating UK spec Registration plate");


                    }

                    break;

                case "N":

                    Console.WriteLine("Fatal error detected, \ncannot generate a Registration Plate for vehicles manufactured before 2001,");

                    Console.WriteLine("Please use a seperate program to register this vehicle on a UK plate");

                    break;
            }

        }
    }
}
