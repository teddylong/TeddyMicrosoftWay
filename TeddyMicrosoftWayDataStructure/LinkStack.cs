using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TeddyMicrosoftWayDataStructure
{
    public class LinkStack<T> : IStack<T>
    {
        private Node<T> top;
        private int num;

        public Node<T> Top
        {
            get { return top; }
            set { top = value; }
        }
        public int Num
        {
            get { return num; }
            set { num = value; }
        }
        public LinkStack()
        {
            top = null;
            num = 0;
        }

        public int GetLength()
        {
            return num;
        }
        public void Clear()
        {
            top = null;
            num = 0;
        }
        public bool IsEmpty()
        {
            if ((top == null) && (num == 0))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Push(T item)
        {
            Node<T> q = new Node<T>(item);
            if (top == null)
            {
                top = q;
            }
            else
            {
                q.Next = top;
                top = q;
            }
            ++num;
        }
        public T Pop()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack is empty!");
                return default(T);
            }
            Node<T> p = top;
            top = top.Next;
            --num;
            return p.Data;
        }
        public T GetTopValue()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack is empty!");
                return default(T);
            }
            return top.Data;
        }
    }
}
