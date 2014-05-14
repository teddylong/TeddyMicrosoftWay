using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TeddyMicrosoftWayDataStructure
{
    public class MySeqList<T> : IListDS<T>
    {
        private int size;
        private int last;
        private T[] data;

        public int Size
        {
            get { return size; }
            set { size = value; }
        }

        public T this[int index]
        {
            get { return data[index]; }
            set { data[index] = value; }
        }

        public int Last
        {
            get { return last; }
        }

        public MySeqList(int max)
        {
            last = -1;
            size = max;
            data = new T[max];
        }

        public int GetLength()
        {
            return last + 1;
        }

        public void Clear()
        {
            last = -1;
        }

        public bool IsEmpty()
        {
            return (last == -1);
        }

        public bool IsFull()
        {
            return (last == size - 1);
        }

        public void Append(T item)
        {
            if (IsFull())
            {
                Console.WriteLine("The SeqList is full!");
            }
            else
            {
                data[++last] = item;
            }
        }

        public void Insert(T item, int i)
        {
            if (IsFull())
            {
                Console.WriteLine("The SeqList is full!");
                return;
            }
            if (i < 1 || i > last + 2)
            {
                Console.WriteLine("The position is error!");
                return;
            }
            if (i == last + 2)
            {
                data[last + 1] = item;
            }
            else
            {
                for (int j = last; j > i - 1; --j)
                {
                    data[j + 1] = data[j];
                }
                data[i - 1] = item;
            }

            ++last;
        }

        public T Delete(int i)
        {
            T tmp = default(T);
            if (IsEmpty())
            {
                Console.WriteLine("The SeqList is Empty");
                return tmp;
            }
            if (i < 1 || i > last + 1)
            {
                Console.WriteLine("The position is error!");
                return tmp;
            }
            if (i == last - 1)
            {
                tmp = data[last--];
            }
            else
            {
                tmp = data[i - 1];
                for (int j = i; j <= last; ++j)
                {
                    data[j] = data[j + 1];
                }

            }
            --last;
            return tmp;
        }

        public T GetElem(int i)
        {
            if (IsEmpty() || i < 1 || i > last + 1)
            {
                Console.WriteLine("SeqList is Empty or the position is error!");
                return default(T);
            }
            return data[i - 1];
        }

        public int Locate(T value)
        {
            if (IsEmpty())
            {
                Console.WriteLine("SeqList is Empty!");
                return -1;
            }
            int i = 0;
            for (i = 0; i < last; ++i)
            {
                if (value.Equals(data[i]))
                {
                    break;
                }
            }
            if (i > last)
            {
                return -1;
            }
            return i;
        }

        public void Reverse()
        {
            T tmp = default(T);
            int len = GetLength();
            for (int i = 0; i < len / 2; ++i)
            {
                tmp = data[i];
                data[i] = data[len - i];
                data[len - i] = tmp;
            }
        }

        public MySeqList<int> MergeIntSeq(MySeqList<int> La, MySeqList<int> Lb)
        {
            MySeqList<int> Lc = new MySeqList<int>(La.Size + Lb.Size);
            int i = 0;
            int j = 0;

            while (i <= La.GetLength() - 1 && j <= Lb.GetLength() - 1)
            {
                if (La[i] < Lb[j])
                {
                    Lc.Append(La[i++]);
                }
                else
                {
                    Lc.Append(Lb[j++]);
                }
            }

            while (i <= La.GetLength() - 1)
            {
                Lc.Append(La[i++]);
            }
            while (j < Lb.GetLength() - 1)
            {
                Lc.Append(Lb[j++]);
            }

            return Lc;
        }

    }
}
