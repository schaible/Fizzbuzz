using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fizzbuzz_Class
{
    public class Fizz_Buzz
    {

        public string[] callout1 = { "fizz", "fuzz", "fizzy", "fuzzy" };
        public string[] callout2 = { "buzz", "bizz", "buzzy", "bizzy" };
        public string[] callout3 = { "fizz buzz", "fuzzy bizz", "bizzy fuzzy", "fizzy bizzy" };

        
        public void Do_Math()
        {
            for (int number = 0; number <= 200; number++)
            {
                if ((number % 3 == 0) && (number % 5 == 0)) 
                {
                    Console.WriteLine(callout3[Randomize()]);
                }
                else if (number % 3 == 0)
                {
                    Console.WriteLine(callout1[Randomize()]);
                }
                else if (number % 5 == 0)
                {
                    Console.WriteLine(callout2[Randomize()]);
                }
                else
                {
                    Console.WriteLine(number);
                }
                number += 1;

            }


        }

        public int Randomize()
        {
            Random rnd = new Random(); 
            return rnd.Next(4);
        }




        

    }
}
