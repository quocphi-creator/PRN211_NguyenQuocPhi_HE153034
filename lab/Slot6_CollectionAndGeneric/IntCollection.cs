using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slot6_ColAndGene_Issue
{
    class IntCollection
    {
        private ArrayList arInts = new ArrayList();
        //get an int (performs unboxing) !
        public int GetInt(int pos) => (int)arInts[pos];
        //insert an int (performs boxing)
        public void AddInt(int n) => arInts.Add(n);
        public void ClearInts() => arInts.Clear();
        public int Count => arInts.Count;
    }
}
