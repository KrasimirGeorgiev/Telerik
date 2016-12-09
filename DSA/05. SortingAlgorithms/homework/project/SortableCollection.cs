namespace SortingHomework
{
    using System;
    using System.Collections.Generic;

    public class SortableCollection<T> where T : IComparable<T>
    {
        private readonly IList<T> items;

        public SortableCollection()
        {
            this.items = new List<T>();
        }

        public SortableCollection(IEnumerable<T> items)
        {
            this.items = new List<T>(items);
        }

        public IList<T> Items
        {
            get
            {
                return this.items;
            }
        }

        public void Sort(ISorter<T> sorter)
        {
            sorter.Sort(this.items);
        }

        public bool LinearSearch(T item)
        {
            for (int i = 0; i < items.Count; i++)
            {
                if (items[i].CompareTo(item) == 0)
                {
                    return true;
                }
            }

            return false;
        }

        public bool BinarySearch(T item)
        {
            int low = 0;
            int high = items.Count - 1;
            int mid = (low + high) / 2;

            while (low <= high && items[mid].CompareTo(item) != 0)
            {
                if (items[mid].CompareTo(item) < 0)
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid - 1;
                }

                mid = (low + high) / 2;
            }

            if (low > high)
            {
                return false;
            }

            return true;
        }

        // Durstenfeld's solution to Fisher–Yates shuffle with complexity O(n) instead of the O(n2) for the original Fisher–Yates shuffle
        public void Shuffle()
        {
            int count = items.Count;
            for (int i = 0; i < count - 2; i++)
            {
                for (int j = i; j < count; j++)
                {
                    var swapVar = items[i];
                    items[i] = items[j];
                    items[j] = swapVar;
                }
            }
        }

        public void PrintAllItemsOnConsole()
        {
            for (int i = 0; i < this.items.Count; i++)
            {
                if (i == 0)
                {
                    Console.Write(this.items[i]);
                }
                else
                {
                    Console.Write(" " + this.items[i]);
                }
            }

            Console.WriteLine();
        }
    }
}
