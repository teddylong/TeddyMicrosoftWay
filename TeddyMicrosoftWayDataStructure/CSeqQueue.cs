using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TeddyMicrosoftWayDataStructure
{
    public class CSeqQueue<T> : IQueue<T>
    {
        private int maxsize;
        private T[] data;
        private int front;
        private int rear;

        public T this[int index]
        {
            get { return data[index]; }
            set { data[index] = value; }
        }
        public int Maxsize
        {
            get
            {
                return maxsize;
            }
            set
            {
                maxsize = value;
            }
        }
        public int Front
        {
            get
            {
                return front;
            }
            set
            {
                front = value;
            }
        }
        public int Rear
        {
            get
            {
                return rear;
            }
            set
            {
                rear = value;
            }
        }
        public CSeqQueue(int size)
        {
            data = new T[size];
            maxsize = size;
            front = rear = -1;
        }

        public T GetFront()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Queue is empty!");
                return default(T);
            }
            return data[front + 1];
        }

        public void In(T item)
        {
            if (IsFull())
            {
                Console.WriteLine("Queue is full");
                return;
            }
            data[++rear] = item;
        }

        public T Out()
        {
            T tmp = default(T);
            if (IsEmpty())
            {
                Console.WriteLine("Queue is empty");
                return tmp;
            }
            tmp = data[++front];
            return tmp;
        }

        public bool IsEmpty()
        {
            if (front == rear)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsFull()
        {
            if ((rear + 1) % maxsize == front)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Clear()
        {
            front = rear = -1;
        }

        public int GetLength()
        {
            return (rear - front + maxsize) % maxsize;
        }


    }
}

