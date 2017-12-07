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

            Console.WriteLine(array);

            Console.ReadKey();

        }
    }
}
