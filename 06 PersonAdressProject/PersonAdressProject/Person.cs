using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonAdressProject
{
    public class Person
    {
        // define attributes
        private string surname;
        private string otherNames;
        private int age;

        //define constructors

        //define methods

        public void SetSurname(string theName)
        {
            surname = theName;
        }
        public string GetSurname()
        {
            return surname;
        }
        public void SetOtherNames(string theName)
        {
            otherNames = theName;
        }
        public string GetOtherNames()
        {
            return otherNames;
        }
        public void Setage(int theage)
        {
            age = theage;
        }
        public int Getage()
        {
            return age;
        }
    }
}
