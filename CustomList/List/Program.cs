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
            CustomList customlist = new CustomList();
            customlist.BuildIndex();
            customlist.DisplayArray();
            Console.ReadKey();

        }
    }
}
