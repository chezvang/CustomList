using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    class List
    {
        public class CustomList<T>
        {
            CustomList<string> list = new CustomList<string>();

            private int listCount;
            private int listCapacity;

            //indexer
            private T[] items;

            public T this[int i]
            {
                get
                {
                    return items[i];
                }
                set
                {
                    items[i] = value;
                }
            }
        }
    }
}
