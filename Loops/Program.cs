using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //For loops
            for (int i = 0; i <= 10; i++){
                Console.WriteLine(i + "i");
            }

            for (int count = 0; count < 20; count += 2)
            {
                Console.WriteLine(count + "count");
            }
            
        }
    }
}
