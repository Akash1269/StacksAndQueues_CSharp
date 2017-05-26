using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StacksUsingArrays
{
    class Stack
    {
        const int MAX_SIZE = 100;
        public int[] list { get; set; }
        public int top { get; set; }

        public Stack()
        {
            top = 0;
            list = new int[MAX_SIZE];
        }

        public bool Push(int data)
        {
            if (top == 100)
                return false;
            list[top] = data;
            top++;
            return true;
        }

        public int Pop()
        {
            if (top == 0)
                return -1;
            top--;
            return list[top];
        }
    }
}
