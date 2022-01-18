using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment
{
    public class Even_Odd
    {
        public void number()
        {
            Console.WriteLine("Enter Number");
            int Number = int.Parse(Console.ReadLine());

            if (Number <= 0)
            {
                Console.WriteLine("Please enter positive number");
            }
            else if (Number % 2 == 0)
            {
                Console.WriteLine(Number+" It is Even Number");
            }
            else
            {
                Console.WriteLine( Number + " It is Odd Number");
            }
        }
    }
}
