using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackQueueProject
{
    class Queue
    {
        private int[] items;

        bool stackMode = true;
        private int front = 0;
        private int back = 0;
        private int length = 0;

        public void add (int Number)
        {
            // adds number
            items[back] = Number;
            back++;
            length++;
        }
        
        public int remove(int Number)
        {
            //removes front
            int temp = items[front];
            front++;
            length--;
            return temp;
        }    
        
        
        
    }
}
