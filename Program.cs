using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int[] myNumbers = { 1, 2, 3, 4, 5, 6 };
                Console.WriteLine(myNumbers[10]);
            }
            catch(Exception e) 
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
