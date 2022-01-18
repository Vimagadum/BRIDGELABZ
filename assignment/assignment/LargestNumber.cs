using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment
{
    public class LargestNumber
    {
        public void number()
        {
            Console.WriteLine("Enter first number");
            int firstnumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int secondnumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter third number");
            int thirdnumber = int.Parse(Console.ReadLine());

            if (firstnumber > secondnumber && firstnumber>thirdnumber)
            {
                Console.WriteLine(firstnumber + " is greater than {0} and {1}", secondnumber, thirdnumber);
            }
            else if (secondnumber>thirdnumber)
            {
                Console.WriteLine(secondnumber+" is greater than {0} and {1}",firstnumber,thirdnumber);
            }
            else
            {
                Console.WriteLine(thirdnumber+" is greater than {0} and {1}",firstnumber,secondnumber);
            }

        }
    }
}
