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
            CustomList<string> array = new CustomList<string>();
            array.AddToArray("1");
            //array.AddToArray("2");
            //array.AddToArray("3");

            //array.RemoveFromArray("2");

            Console.WriteLine(array[0]);
            //Console.WriteLine(array.CountIntList);

            Console.ReadKey();

        }
    }
}
