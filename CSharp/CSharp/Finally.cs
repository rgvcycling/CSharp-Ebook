using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp
{
    class Finally
    {
        static void Main()
        {
            try
            {
                // get random number
                // if the number is 0, an error will occur
                // if the number is 1, the method returns
                // otherwise, fall through to the end

                // return random number 0 <= random # <=3
                int random = new Random().Next(0, 3); 
                if(random ==0)
                {
                    throw new Exception("Random # = 0. Exception thrown.");
                }
                if(random==1)
                {
                    Console.WriteLine("Random # = 1. Return is executed.");
                    return;
                }
                Console.WriteLine("Random # is 2. Exited normally.");
            }
            finally
            {
                // This statement is executed before the Main() method exits
                // it is reached when an exception is thrown
                // Also reached after the return statement and is also reached in other cases too

                Console.WriteLine("\nControl flow reaches the finally block");

            }
        }
    }
}
