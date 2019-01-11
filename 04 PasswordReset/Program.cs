using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordReset
{
    class Program
    {
        static void Main(string[] args)
        {
            string Password1 = "";

            string Password2 = "";

            int length = Password1.Length;

            

            Console.WriteLine("Please enter your new password");

            Password1 = Console.ReadLine();

            Console.WriteLine("Please re-enter your new password");

            Password2 = Console.ReadLine();

            byte[] asciiBytes = Encoding.ASCII.GetBytes(Password1);

            int upperCount = 0;
            int lowerCount = 0;

            for (int i = 0; i <= asciiBytes.Length - 1; i++)
            {
                if (asciiBytes[i] >= 65 && asciiBytes[i] <=90 )
                    upperCount = upperCount + 1;
                else if (asciiBytes[i] >= 97 && asciiBytes[i] <= 122 )
                    lowerCount = lowerCount + 1;


            }
            



            if (Password1.Any(c => char.IsLower(c))&& Password1.Any(c => char.IsUpper(c))) // internet code forumn said use this, so i am trying it oof me// modified for lower keys, and works?
            {
                Console.WriteLine("Password error, no upper and lower case keys found");
            }

            else if (Password1 != Password2)
            {
                Console.WriteLine("Error, Passwords do not match");
            }
            else if (Password1.Length >= 8) // other mark helped with this //function learned from internet
            {
                Console.WriteLine("Password Reset accepted");
            }

            else
            {

                Console.WriteLine("Password void, must contain 8 or more characters");
            }
            Console.ReadLine();

        }
    }
}
