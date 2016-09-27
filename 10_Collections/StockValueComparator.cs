using System;
using System.Collections.Generic;

namespace _10_Collections
{
    internal class StockValueComparator : IComparer<IAsset>
    {
        public int Compare(IAsset firstvalue, IAsset secondvalue)
        {
            return secondvalue.GetValue().CompareTo(firstvalue.GetValue());
        }
    }
}