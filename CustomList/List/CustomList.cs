using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    public class CustomList <T>
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

        public CustomList()
        {
            items = new T[listCapacity];
        }

        //methods
        public void AddToArray()
        {
            for (int i = 1; i < arrayCapacity; i++)
            {
                arrayOne[i-1] = "test";
            }
        }

        public int CountArray()
        {
            arrayCount = arrayOne.Count();

            return arrayOne.Count();
        }

        public int CapacityArray()
        {
            arrayCapacity = arrayOne.Count() + 1;

            return arrayOne.Count();
        }
    }
}
