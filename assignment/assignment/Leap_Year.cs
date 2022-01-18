using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment
{
    public class Leap_Year
    {
           public void year()
           {
                Console.WriteLine("Enter year");
                int yearis = int.Parse(Console.ReadLine());

                if (yearis.ToString().Length != 4)
                {
                    Console.WriteLine("Please enter valid year");
                }
                else if (((yearis % 4 == 0) && (yearis % 100 != 0)) || (yearis % 400 == 0))
                {
                    Console.WriteLine(" " + yearis + "Year is Leap Year");
                }
                else
                {
                    Console.WriteLine(" " + yearis + "Year is not Leap Year");
                }
           }

    }
}
