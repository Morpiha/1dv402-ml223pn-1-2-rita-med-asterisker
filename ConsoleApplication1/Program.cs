using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 25; i++)
            {
         
                for (int j = 0; j < 39; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
                if(i%2==0)
                {
                    Console.Write(" ");
                }
            }
        }
    }
}
