using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2
{
    class Program
    {
        static void Main(string[] args)
        {
          
            int i, j; // rows
            for( i = 1; i <= 3; i++)  //This is loop for arrange the space
            {
                for(j=1; j<=i;j++)  //This loop for arange the space
                {
                    Console.Write("[*]");
                }
                Console.WriteLine();
            }
        }
    }
}
