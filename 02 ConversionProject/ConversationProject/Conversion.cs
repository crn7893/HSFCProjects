using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversationProject
{
    public class Conversion
    {
        public String ReverseString (String myString)
        {

            String NewString = "";

            for (int num = 0; num < myString.Length; num++)
            {
                NewString = myString.Substring(num, 1) + NewString;
            }
            return NewString;

        }
    }
}
