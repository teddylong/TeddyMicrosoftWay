using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TeddyMicrosoftWayDataStructure
{
    // 链表
    public class LinkList<T> : IListDS<T>
    {
        private Node<T> head;

        public Node<T> Head
        {
            get { return head; }
            set { head = value; }
        }
        public LinkList()
        {
            head = null;
        }

        public T GetElem(int i)
        {
            if (IsEmpty())
            {
                Console.WriteLine("List is empty!");
                return default(T);
            }
            Node<T> p = new Node<T>();
            p = head;
            int j = 1;
            while (p.Next != null && j < i)
            {
                ++j;
                p = p.Next;
            }
            if (j == i)
            {
                return p.Data;
            }
            else
            {
                Console.WriteLine("The item node is not exist!");
                return default(T);
            }
        }

        public void Append(T item)
        {
            Node<T> q = new Node<T>(item);
            Node<T> p = new Node<T>();
            if (head == null)
            {
                head = q;
                return;
            }
            p = head;
            while (p != null)
            {
                p = p.Next;
            }
            p.Next = q;
        }

        public bool IsEmpty()
        {
            return (head == null);
        }

        public void Clear()
        {
            head = null;
        }

        public T Delete(int i)
        {
            if (IsEmpty() || i < 0)
            {
                Console.WriteLine("Link is Empty or the Position is error!");
                return default(T);
            }
            Node<T> q = new Node<T>();

            if (i == 1)
            {
                q = head;
                head = head.Next;
                return q.Data;
            }
            Node<T> p = head;
            int j = 1;

            while (p.Next != null && j < i)
            {
                ++j;
                q = p;
                p = p.Next;
            }

            if (j == i)
            {
                q.Next = p.Next;
                return p.Data;
            }
            else
            {
                Console.WriteLine("The item node is not exist!");
                return default(T);
            }

        }

        public void Insert(T item, int i)
        {
            if (IsEmpty() || i < 1)
            {
                Console.WriteLine("List is Empty or the Position is error!");
            }
            if (i == 1)
            {
                Node<T> q = new Node<T>(item);
                q.Next = head;
                head = q; ;
                return;
            }

            Node<T> p = head;
            Node<T> r = new Node<T>();
            int j = 1;

            while (p.Next != null && j < i)
            {
                r = p;
                p = p.Next;
                ++j;
            }

            if (j == i)
            {
                Node<T> q = new Node<T>(item);
                q.Next = p;
                r.Next = q;
            }
        }

        public void InsertPost(T item, int i)
        {
            if (IsEmpty() || i < 1)
            {
                Console.WriteLine("List is Empty or the Position is error!");
            }
            if (i == 1)
            {
                Node<T> q = new Node<T>(item);
                q.Next = head.Next;
                head.Next = q;
                return;
            }

            Node<T> p = head;
            int j = 1;

            while (p.Next != null && j < i)
            {
                p = p.Next;
                j++;
            }
            if (j == i)
            {
                Node<T> q = new Node<T>(item);
                q.Next = p.Next;
                p.Next = q;
            }

        }

        public int Locate(T item)
        {
            if (IsEmpty())
            {
                Console.WriteLine("List is Empty!");
                return -1;
            }
            Node<T> p = new Node<T>();
            p = head;
            int i = 1;
            while (!p.Data.Equals(item) && p.Next != null)
            {
                p = p.Next;
                ++i;
            }
            return i;
        }

        public int GetLength()
        {
            Node<T> p = head;
            int len = 0;
            while (p != null)
            {
                ++len;
                p = p.Next;
            }
            return len;
        }

        public void ReversLinkList()
        {
            Node<T> p = head.Next;
            Node<T> q = new Node<T>();
            head.Next = null;
            while (p != null)
            {
                q = p;
                p = p.Next;
                q.Next = head.Next;
                head.Next = q;
            }
        }
    }
}
