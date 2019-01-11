using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackProject
{
    class stackClass
    {
        private string[] myStack = new string[100];

        int Top = 0;

        public void Push(string stackSegment)
        {
            myStack[Top] = stackSegment;
            Top++;
        }

        public string Pop()
        {
            Top--;
            return myStack[Top];
        }

        public int Depth()
        {
            return Top;
        }




    }
}

