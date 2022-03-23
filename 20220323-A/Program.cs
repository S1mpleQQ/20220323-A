using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20220323_A
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("階層=");
            int n = Convert.ToInt32(Console.ReadLine());
            int result = 1;
                for (int i = 1; i <= n; i++) 
            {
                result = result * i;
            }
            Console.WriteLine("{0}!={1}", n, result);
            Console.ReadLine();
        }
    }
}
