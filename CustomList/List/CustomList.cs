using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    public class CustomList <T>
    {

        private int arrayCount; //keeps track of count
        private int arrayCapacity; //keeps track of capacity

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
            }
            else if (arrayCount >= arrayCapacity)
            {
                arrayCapacity = arrayCapacity + 1;
                arrayCount = 0;
                T[] tempItems = new T[arrayCapacity];
                foreach (T other in items)
                {
                    tempItems[arrayCount] = other;
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

            count = items.Count();
            return count;
        }

        public override string ToString()
        {
            string newString;

            newString = items[0].ToString();

            return newString;
        }

        private bool Contains(T item)
        {
            for (int i = 0; i < arrayCount; i++)
            {
                if (items[i].Equals(item))
                {
                    return true;
                }
            }
            return false;
        }

        public static CustomList<T> operator + (CustomList<T>list1, CustomList<T>list2)
        {
            CustomList<T> list3 = new CustomList<T>();

            //if (list1 != null && list2 != null)
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

        public static CustomList<T> operator - (CustomList<T> list1, CustomList<T> list2)
        {
            CustomList<T> list3 = new CustomList<T>();

            if (list1 != null && list2 != null)
            {
                for (int i = 0; i < list2.arrayCount; i++)
                {
                    if (!list1.Contains(list2[i]))
                    {
                        list3.AddToArray(list2[i]);
                    }
                }                   
            }
            return list3;
        }

        public CustomList<T> Zip(CustomList<T>list1, CustomList<T>list2)
        {
            CustomList<T> result = new CustomList<T>();
            try
            {
                if (list1.arrayCount <= list2.arrayCount)
                {
                    for (int i = 0; i < list1.arrayCount; i++)
                    {
                        result.AddToArray(list1[i]);
                        result.AddToArray(list2[i]);
                    }
                    for (int j = result.arrayCount - 1; j < list2.arrayCount; j++)
                    {
                        result.AddToArray(list2[j]);
                    }
                }
                else
                {
                    for (int i = 0; i < list2.arrayCount; i++)
                    {
                        result.AddToArray(list1[i]);
                        result.AddToArray(list2[i]);
                    }
                    for (int j = result.arrayCount - 1; j <= list1.arrayCount; j++)
                    {
                        result.AddToArray(list1[j]);
                    }
                }
                return result;
            }
            catch(Exception)
            {
                throw new ArgumentNullException();
            }
        }

    }
}
