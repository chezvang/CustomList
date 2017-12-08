using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomList<int> list1 = new CustomList<int>();
            CustomList<int> list2 = new CustomList<int>();
            CustomList<int> list3 = new CustomList<int>();
            int one = 2;
            int two = 3;
            int three = 1;
            int four = 4;

            list1.AddToArray(one);
            list1.AddToArray(two);
            list1.AddToArray(three);
            list1.AddToArray(four);
            ////list2.AddToArray(three);
            ////list2.AddToArray(four);

            list3 = list1;

            //Console.WriteLine(list3[0]);
            Console.WriteLine(list1[0]);
            Console.WriteLine(list1[1]);
            Console.WriteLine(list1[2]);
            Console.WriteLine(list1[3]);

            Console.ReadKey();

        }
    }
}
