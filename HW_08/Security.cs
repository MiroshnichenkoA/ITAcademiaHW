using System;
using System.Collections.Generic;
using System.Text;

namespace HW_08
{
    class Security
    {
        public void Check()
        {
            Console.WriteLine("Please, put off your shoes and put off all things out of your pokets");
            int numOfProhibitedThings = SearchedProhibitedThings();
            while (numOfProhibitedThings > 0)
            {
                Console.WriteLine($"I found {numOfProhibitedThings} forbidden things. You can't pass unless you throw them away. I'm waiting! Don't make me call the police!");
                numOfProhibitedThings = SearchedProhibitedThings();
            }
            Console.WriteLine("Ok. You can pass");
        }

        public int SearchedProhibitedThings()
        {
            Random random = new Random();
            int num = random.Next(0, 3);
            return num;
        }
    }
}
