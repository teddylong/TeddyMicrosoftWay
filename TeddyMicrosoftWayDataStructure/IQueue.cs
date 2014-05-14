using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TeddyMicrosoftWayDataStructure
{
    public interface IQueue<T>
    {
        int GetLength();
        bool IsEmpty();
        void Clear();
        void In(T item);
        T Out();
        T GetFront();
    }
}
