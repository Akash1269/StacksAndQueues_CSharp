using System;

namespace StacksUsingLinkedList
{
    class Stack
    {
        public Node Top { get; set; }

        public Stack()
        {
            Top = null;
        }

        public bool Push(int data)
        {
            try
            {
                Node node = new Node() { Data = data, Next = null };
                node.Next = Top;
                Top = node;
                return true;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
                return false;
            }
        }
        public int Pop()
        {
            if (Top == null)
            {
                return -1;
            }
            int data = Top.Data;
            Top = Top.Next;
            return data;
        }

    }
}
