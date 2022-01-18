using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment
{
    public class VowelorConsonant
    {
        public void charecter()
        {
            char charrr;

            Console.WriteLine("Enter alphabet to check vowel or consonant ");
            
            charrr = Convert.ToChar(Console.ReadLine().ToLower());
            
            
                switch (charrr)
                {
                    case 'a':
                        Console.WriteLine("The Alphabet is vowel");
                        break;
                    case 'i':
                        Console.WriteLine("The Alphabet is vowel");
                        break;
                    case 'o':
                        Console.WriteLine("The Alphabet is vowel");
                        break;
                    case 'u':
                        Console.WriteLine("The Alphabet is vowel");
                        break;
                    case 'e':
                        Console.WriteLine("The Alphabet is vowel");
                        break;
                    default:
                        Console.WriteLine("The Alphabet is Consonant");
                        break;
                }
            
            

        }
    }
}
