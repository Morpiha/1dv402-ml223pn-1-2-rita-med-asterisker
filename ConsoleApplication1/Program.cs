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
                int rowColor = i % 3;
                switch (rowColor)
                {
                    case 0:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        break;
                    
                    case 1:
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        break;

                    case 2:
                        Console.ForegroundColor = ConsoleColor.Green;
                        break;
                        
                        
                }
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
