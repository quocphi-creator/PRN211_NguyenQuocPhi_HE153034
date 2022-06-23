using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slot6_IEnurableInterface
{
    public class MyCollection<T> : IEnumerable where T : class, new()
    {
        private List<T> myList = new List<T>();
        public void AddItem(params T[] item) => myList.AddRange(item);
        IEnumerator IEnumerable.GetEnumerator() => myList.GetEnumerator();
    }
   
}
