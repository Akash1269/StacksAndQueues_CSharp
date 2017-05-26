using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueUsingLinkedList
{
    class Queue
    {
        public Node Front { get; set; }
        public Node Rear { get; set; }
        
        public Queue()
        {
            Front = Rear = null;
        }
        public bool Push(int data)
        {
            Node node = new Node() { Data = data, Next = null };
            if (Front == null)
            {
                Front = Rear = node;
                return true;
            }

            Rear.Next = node;
            Rear = node;
            return true;
        }
        public int Pop()
        {
            if (Front == null)
                return -1;

            int data = Front.Data;
            Front = Front.Next;
            return data;
        }
    }
}
