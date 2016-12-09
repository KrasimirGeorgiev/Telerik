namespace SortingHomework
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class MergeSorter<T> : ISorter<T> where T : IComparable<T>
    {
        public void Sort(IList<T> collection)
        {
            MergeSort(collection, 0, collection.Count - 1);   
        }

        private void DoMerge(IList<T> collection, int left, int mid, int right)
        {
            var temp = new T[collection.Count];
            int i;
            int leftEnd;
            int numElements;
            int tmpPos;

            leftEnd = (mid - 1);
            tmpPos = left;
            numElements = (right - left + 1);

            while ((left <= leftEnd) && (mid <= right))
            {
                if (collection[left].CompareTo(collection[mid]) <= 0)
                {
                    temp[tmpPos++] = collection[left++];
                }
                else
                {
                    temp[tmpPos++] = collection[mid++];
                }
            }

            while(left <= leftEnd)
            {
                temp[tmpPos++] = collection[left++];
            }

            while (mid <= right)
            {
                temp[tmpPos++] = collection[mid++];
            }

            for (i = 0; i < numElements; i++)
            {
                collection[right] = temp[right];
                right--;
            }
        }

        private void MergeSort(IList<T> collection, int left, int right)
        {
            int mid;

            if (right > left)
            {
                mid = (right + left) / 2;
                MergeSort(collection, left, mid);
                MergeSort(collection, (mid + 1), right);

                DoMerge(collection, left, (mid + 1), right);
            }
        }
    }
}
