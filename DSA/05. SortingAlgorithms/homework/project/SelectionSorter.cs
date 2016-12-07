namespace SortingHomework
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class SelectionSorter<T> : ISorter<T> where T : IComparable<T>
    {
        public void Sort(IList<T> collection)
        {
            int len = collection.Count();
            for (int i = 0; i < len - 1; i++)
            {
                int minElement = i;
                for (int j = i + 1; j < len; j++)
                {
                    if (collection[j].CompareTo(collection[minElement]) < 0)
                    {
                        minElement = j;
                    }
                }

                if (minElement != i)
                {
                    var swapVariable = collection[minElement];
                    collection[minElement] = collection[i];
                    collection[i] = swapVariable;
                }
            }
        }
    }
}
