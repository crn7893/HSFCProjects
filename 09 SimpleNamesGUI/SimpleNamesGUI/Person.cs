using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleNamesGUI
{

        public class Person

        {

            private String name = "";



            private int age = 0;



            // constructor just takes a name 

            public Person(String aName)

            {

                name = aName;

            }



            // setName procedure allows a user to set a Person's name 

            public void setName(String theString)

            {

                name = theString;

            }



            //getName function returns a Person's name 

            public String getName()

            {

                return name;

            }



            // setAge procedure allows a user to set a Person's age 

            public void setAge(int theAge)

            {

                age = theAge;

            }



            //getAge function returns a Person's age 

            public int getAge()

            {

                return age;

            }

        }
}
