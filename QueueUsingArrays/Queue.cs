using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueUsingArrays
{
    class Queue
    {
        const int MAX_SIZE = 10;
        public int[] list { get; set; }
        public int front { get; set; }
        public int rear { get; set; }
        public int size { get; set; }

        public Queue()
        {
            list = new int[MAX_SIZE];
            rear = -1;
            front = 0;
            size = 0;
        }
        public bool Push(int data)
        {
            if (size == MAX_SIZE)
                return false;

            rear = (rear + 1) % MAX_SIZE;
            list[rear] = data;
            size++;

            return true;
        }
        public int Pop()
        {
            if (size == 0)
                return -1;

            int data = list[front];
            front = (front + 1) % MAX_SIZE;
            size--;
            return data;
        }
    }
}
