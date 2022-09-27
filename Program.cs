using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int total = 0;
            for (int n = 1; n <= 500; n++) {total += n;}
            Console.WriteLine(total);
        }
    }
}
