using System;
using Algorithm.Core.Common;

namespace Algorithm.BaseCollection.Common
{
    public interface ISortingAlgorithm<in T> : IAlgorithm<T[]> where T : IComparable, IComparable<T>
    {
        void Sort(T[] array);
    }
}
