using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameListProject
{
    public class NameList
    {
        private string[] items = new string[100];

        private int nextFreeLoc = 0;

        public int GetPosition()
        {
            GetPosition = nextFreeLoc;

        }
        public void AddName(string theName);
        {
            Console.WriteLine("Please enter a new name");

            items[] = Console.ReadLine();
        }
    }
}
//>goes to teams
//>>does what teams has
//>>>Teams gives me more errors than i had for help
//>>>>Teacher said i would help me