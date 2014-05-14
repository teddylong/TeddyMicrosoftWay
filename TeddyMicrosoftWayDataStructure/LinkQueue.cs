using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TeddyMicrosoftWayDataStructure
{
    //队列
    public class LinkQueue<T> : IQueue<T>
    {
        private Node<T> front;
        private Node<T> rear;
        private int num;

        public Node<T> Front
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
        public Node<T> Rear
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
        public int Num
        {
            get
            {
                return num;
            }
            set
            {
                num = value;
            }
        }
        public LinkQueue()
        {
            front = rear = null;
            num = 0;
        }

        public T GetFront()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Queue is empty!");
                return default(T);
            }
            return front.Data;
        }

        public void In(T item)
        {
            Node<T> q = new Node<T>(item);
            if (rear == null)
            {
                rear = q;
            }
            else
            {
                rear.Next = q;
                rear = q;
            }
            ++num;
        }

        public T Out()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Queue is empty!");
                return default(T);
            }
            Node<T> p = front;
            front = front.Next;
            if (front == null)
            {
                rear = null;
            }
            --num;
            return p.Data;
        }

        public bool IsEmpty()
        {
            if ((front == rear) && (num == 0))
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
            num = 0;
            front = rear = null;
        }

        public int GetLength()
        {
            return num;
        }

    }
}
