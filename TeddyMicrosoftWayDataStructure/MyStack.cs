using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TeddyMicrosoftWayDataStructure
{
    // 栈
    public class MyStack<T> : IStack<T>
    {
        private int size;
        private T[] data;
        private int top;

        public T this[int index]
        {
            get { return data[index]; }
            set { data[index] = value; }
        }
        public int Size
        {
            get { return size; }
            set { size = value; }
        }

        public int Top { get { return top; } }

        public MyStack(int length)
        {
            top = -1;
            size = length;
            data = new T[length];
        }

        public int GetLength()
        {
            return top + 1;
        }

        public bool IsEmpty()
        {
            return (top == -1);
        }

        public bool IsFull()
        {
            if (top == size - 1)
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
            top = -1;
        }

        public void Push(T item)
        {
            if (IsFull())
            {
                Console.WriteLine("Stack is full");
                return;
            }
            data[++top] = item;
        }

        public T Pop()
        {
            T tmp = default(T);
            if (IsEmpty())
            {
                Console.WriteLine("Stack is empty");
                return tmp;
            }
            tmp = data[top];
            --top;
            return tmp;
        }
        public T GetTopValue()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack is empty!");
                return default(T);
            }
            return data[top];
        }
    }
}
