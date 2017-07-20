using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp
{
    public class InvalidAgedException:Exception
    {
        public InvalidAgedException(string message) : base(message)
        {

        }
    }

    public class TestUserDefinedException
    {
        static void validate(int age)
        {
            if(age<18)
            {
                throw new InvalidAgedException("Sorry, your age must be 18 or greater");
            }
        }
    
        static void Main()
        {
            try
            {
                Console.WriteLine("Enter your age:");
                validate(Convert.ToInt32(Console.ReadLine()));
            }

            catch (InvalidAgedException e)
            {
                // displays the error message that was thrown in the validate() 
                // and continue with the program flow
                Console.WriteLine(e);
                Console.WriteLine("Execution of the rest of the code");
            }
        }
    }
}
