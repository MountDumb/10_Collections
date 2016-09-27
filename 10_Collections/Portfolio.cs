using System;
using System.Collections.Generic;

namespace _10_Collections
{
    public class Portfolio
    {
        //Fields
        private List<IAsset> portlist = new List<IAsset>();
        //Constructors
        public Portfolio(List<IAsset> portlist)
        {
            this.portlist = portlist;
        }
        public Portfolio()
        {

        }
        //Methods
        public double GetTotalValue()
        {
            double totalvalue = 0;
            for (int i = 0; i < portlist.Count; i++)
            {
                totalvalue += portlist[i].GetValue();
            }

            return totalvalue;
        }

        //gone due to refactoring.
        //public static double TotalValue(List<IAsset> assets)
        //{
        //    return new Portfolio(assets).GetTotalValue();

        //}

        public void AddAsset(IAsset ass)
        {
            this.portlist.Add(ass);
        }

        public IList<IAsset> GetAssets()
        {
            return portlist;
        }

        public IAsset GetAssetByName(string name)
        {
            foreach (IAsset asset in portlist)
            {
                if (asset.Symbol == name)
                {
                    return asset;
                }
            }
            return null;
        }

        public IList<IAsset> GetAssetsSortedByName()
        {
            IComparer<IAsset> com = new StockNameComparator();
            portlist.Sort(com);
            return portlist;
            
        }

        public IList<IAsset> GetAssetsSortedByValue()
        {
            IComparer<IAsset> com = new StockValueComparator();
            portlist.Sort(com);
            return portlist;
        }

        //Properties

       
    }
}