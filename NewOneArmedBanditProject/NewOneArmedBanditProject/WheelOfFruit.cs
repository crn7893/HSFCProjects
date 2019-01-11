using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using NewOneArmedBanditProject.Properties;
using System.Windows.Forms;

namespace NewOneArmedBanditProject
{
    class WheelOfFruit
    {
        Random MyRand = new Random();

        // enumerated type of fruits that is available to everyone 

        public enum Fruits { Apple, Banana, Pikachu, Grape, Orange, Pair, Raspberry, Strawberry }



        private Fruits[] theWheel = new Fruits[8]; 
        // ok so i think this is making an array using the strings above crn



        const int viewPos = 4; // used to indicate the central fruit on display 



        // default constructor  

        public WheelOfFruit()

        {

            // initialise the array with each fruit, Apple to position 0, Banana to 1, etc 

            for (int i = 0; i < theWheel.Length; i++)
                // a loop that lasts until it reaches the end of the wheel ( AKA the 8 set on line 19) crn
            {

                theWheel[i] = (Fruits)i;

            }

            // call shuffle to shuffle the set of fruits 

            this.shuffle();

        }



        // shuffle is used to make sure that not all wheels are the same - the order should be different 

        private void shuffle()

        {

            int first, second;          // we are going to repeatedly swap first and second 



            Fruits temp;                //  temp location for swap- try swapping two melons with two hands!! 



            // to shuffle, we generate two random numbers and swap the fruits between them 

            for (first = 0; first < theWheel.Length; first++)

            {

                second = MyRand.Next(0, theWheel.Length);  // get a random value within range 



                // Now swap 

                temp = theWheel[first];

                theWheel[first] = theWheel[second];

                theWheel[second] = temp;



            }
            // a for loop that randomises how many the first wheel will move crn
        }



        // spin is used to spin the wheel so many notches  

        // Note that Wheel.Length notches represents a complete rotation 

        public void spin(int num)

        {

            Fruits front; // used to store the Fruit at the front which will go to the back 



            for (int notch = 0; notch < num; notch++)

            {

                // each notch represents a single shunt down the array. moving front to back 

                front = theWheel[0];

                for (int i = 0; i < theWheel.Length - 1; i++)

                {

                    theWheel[i] = theWheel[i + 1];

                }

                theWheel[theWheel.Length - 1] = front;

            }
            // i do not understand what this does crn
        }



        public Fruits getCurrentFruit()

        {

            return theWheel[viewPos];  // returns the fruit at viewpoint 

        }
        //Makes the fruit the randomisers have landed on show on the front layer (so can be viewed and not hidden behind crn )
    }
}
