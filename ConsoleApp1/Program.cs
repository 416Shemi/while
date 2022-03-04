using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToUInt16(Console.ReadLine());
            int m = Convert.ToUInt16(Console.ReadLine());
            int s = 0;
           while(n<m)
            {
                n++;
                if (n % 7 == 0)
                {
                    s++;
                }
               
               
            }
            Console.WriteLine(s);
            Console.ReadLine();
        }
    }
}
