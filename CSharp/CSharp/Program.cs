using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace CatchingErrors
{
    class Shapestry
    {
        static void Main()
        {
            try
            {
                throw new ArgumentException("Invalid x argument");
            }
            catch (ArgumentException ex) when (ex.Message == "Invalid x argument")
            {
                Console.WriteLine("X");
            }
            catch (ArgumentException ex) when (ex.Message == "Invalid y argument")
            {
                Console.WriteLine("Y");
            }

        }
    }

}