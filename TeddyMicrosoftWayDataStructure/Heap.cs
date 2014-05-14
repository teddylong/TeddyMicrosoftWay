using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TeddyMicrosoftWayDataStructure
{
    class Heap
    {
        private int[] m_heapArr;
        private int m_count;
        
        public Heap(int[] numbers, int arrSize)
        {
            m_heapArr = new List<int>(numbers).ToArray();
            m_count = arrSize;

            makeHeap();
        }

        public int getRootValue()
        {
            return m_heapArr[0];
        }

        public void DeleteRoot()
        {
            Swap(0, m_count - 1);
            m_count--;
            shift_down(0);
        }

        private void makeHeap()
        {
            for (int i = getParentIdx(m_count - 1); i >= 0; i--)
            {
                shift_down(i);
            }
        }

        private void shift_down(int pos)
        {
            if (getSonLeftIdx(pos) == -1)
                return;

            bool done = false;
            while (!done)
            {
                int sonToExchange = getSonLeftIdx(pos);
                int sonRight = getSonRightIdx(pos);


                if (sonRight != -1)
                {

                    if (m_heapArr[sonToExchange] > m_heapArr[sonRight])
                    {
                        sonToExchange = sonRight;
                    }
                }

                if (m_heapArr[pos] > m_heapArr[sonToExchange])
                {
                    Swap(pos, sonToExchange);
                    pos = sonToExchange;
                }
                else
                {
                    done = true;
                }

                //已经没有儿子了
                if (getSonLeftIdx(pos) == -1)
                    return;
            }
        }

        private int getSonLeftIdx(int parent)
        {
            int son = 2 * parent + 1;
            if (son >= m_count)
                return -1;
            return son;
        }

        private int getSonRightIdx(int parent)
        {
            int sonr = 2 * parent + 2;
            if (sonr >= m_count)
                return -1;
            return sonr;
        }

        private int getParentIdx(int son)
        {
            if (son < 0)
                return -1;
            if (son == 0)
                return 0;

            return (son + 1) / 2 - 1;
        }

        private void Swap(int idx1, int idx2)
        {
            int temp = m_heapArr[idx1];
            m_heapArr[idx1] = m_heapArr[idx2];
            m_heapArr[idx2] = temp;
        }

    }
}
