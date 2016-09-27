using System.Globalization;
using System.Collections.Generic;
using System;

namespace _10_Collections
{
    public class StockNameComparator : IComparer<IAsset>
    {
        
        public int Compare(IAsset firstasset, IAsset secondasset)
        {
            return firstasset.Symbol.CompareTo(secondasset.Symbol); 
          
          
        }
    }
}