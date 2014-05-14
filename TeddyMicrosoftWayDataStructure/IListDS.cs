using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TeddyMicrosoftWayDataStructure
{
    public interface IListDS<T>
    {
        // Get Length of the list
        int GetLength();
        // Clear the list
        void Clear();
        // Is Empty or not
        bool IsEmpty();
        // Append one item to the list
        void Append(T item);
        // Insert one item to the list in the "i" position
        void Insert(T item, int i);
        // Delete one item in the list
        T Delete(int i);
        // Get one item from the list
        T GetElem(int i);
        // Locate one item by its value
        int Locate(T item);
    }
}
