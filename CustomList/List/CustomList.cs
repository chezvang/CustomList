using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    public class CustomList <T>
    {
        //CustomList<string> array = new CustomList<string>();

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
            arrayCapacity = 1;
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
            //else if (arrayCount >= arrayCapacity)
            //{
            //    arrayCapacity = arrayCapacity + 1;
            //    //arrayCount = 0;

            //    T[] temporaryItem = new T[arrayCapacity];

            //    foreach (T thing in items) //change thing
            //    {
            //        temporaryItem[arrayCount] = thing; //change thing
            //        arrayCount++;
            //    }
            //    temporaryItem[arrayCount] = item;
            //    items = new T[arrayCapacity];
            //    arrayCount++;
            //    items = temporaryItem;
            //}
        }

        public void RemoveFromArray(string T)
        {

        }
    }
}
