using System;
using Algorithm.Core;
using Algorithm.Core.Common;

namespace Algorithm.BaseCollection.Sorting
{
    public class InsertionSort<T> : IAlgorithm<T[]> where T : IComparable, IComparable<T>
    {
        public AlgorithmResult Handle(T[] array)
        {
            Sort(array);

            return AlgorithmResult.Success();
        }

        public void Sort(T[] array)
        {
            for (var i = 1; i < array.Length; i++)
            {
                var item = array[i];
                var j = i;
                while (array[j - 1].CompareTo(item) > 0)
                {
                    array[j] = array[j - 1];
                    array[j - 1] = item;
                    if (j != 1)
                        j--;
                }
            }
        }

        // Other realization
        //public void Sort<T>(T[] array) where T : IComparable, IComparable<T>
        //{
        //    for (var i = 1; i < array.Length; ++i)
        //        for (var j = i; j > 0 && (array[j - 1].CompareTo(array[j]) > 0); --j)
        //        {
        //            var temp = array[j - 1];
        //            array[j - 1] = array[j];
        //            array[j] = temp;
        //        }
        //}
    }
}
