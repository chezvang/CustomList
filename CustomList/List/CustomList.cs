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
            }
            else if (arrayCount >= arrayCapacity)
            {
                arrayCapacity++;
                arrayCount = 0;
                T[] tempItems = new T[arrayCapacity];
                //arrayCount++;
                foreach (T thing in items) //change thing
                {
                    //arrayCount++;
                    tempItems[arrayCount] = thing;
                    arrayCount++;
                }
                tempItems[arrayCount] = item;
                items = new T[arrayCapacity];
                arrayCount++;
                items = tempItems;
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
            int count;
            return count = items.Count();
        }

        public override string ToString()
        {
            string newString;

            newString = items[0].ToString();

            return newString;
        }

        public static CustomList<T> operator + (CustomList<T>list1, CustomList<T>list2)
        {
            CustomList<T> list3 = new CustomList<T>();

            // if (list1 != null && list2 != null)
            //{
            for (int i = 0; i < list1.arrayCount; i++)
            {
                list3.AddToArray(list1.items[i]);
            }
            for (int i = 0; i < list2.arrayCount; i++)
            {
                list3.AddToArray(list2.items[i]);
            }
            //}
        return list3;
        }
    }
}
