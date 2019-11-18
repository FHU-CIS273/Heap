using System;
using System.Collections.Generic;

namespace Heap
{
    public class MaxHeap<T> where T : IComparable<T>
    {
        private List<T> list;
        //T[] array;

        public int Count => list.Count;
        public bool IsEmpty => Count == 0;

        public MaxHeap()
        {
            list = new List<T>();
        }


        public void Add(T item)
        {
            // add to end of list

            // percolate up from new node (end)
        }

        private void PercolateUp(int startingIndex)
        {

        }

        public T RemoveMax()
        {
            // save root/max


            // replace with last element
            

            // percolate down from root

            return default;
        }

        private void PercolateDown(int startingIndex)
        {

        }

        public T PeekMax()
        {
            return IsEmpty? default: list[0];
        }

        public void Clear()
        {
            list.Clear();
        }
    }
}
