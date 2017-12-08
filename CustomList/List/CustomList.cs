using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    public class CustomList <T>
    {

        public int arrayCount; //keeps track of count
        public int arrayCapacity; //keeps track of capacity

        //indexer
        public T[] items;
        
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
            arrayCapacity = 3;
            arrayCount = 0;
            items = new T[arrayCapacity];
        }

        public void AddToArray(T item)
        {
            if (arrayCount < arrayCapacity)
            {
                items[arrayCount] = item;
                arrayCount++;
                arrayCapacity++;
            }

        }

        public void RemoveFromArray(T item)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i].Equals(item))
                {
                    arrayCapacity--;
                    RemoveArrayStart(i);
                }
            }
        }

        public void RemoveArrayStart(int start)
        {
            for (int i = start; i < arrayCount - 1; i++)
            {
                items[i] = items[i + 1];
            }
        }

        public int CountList()
        {
            return items.Count();
        }
    }
}
