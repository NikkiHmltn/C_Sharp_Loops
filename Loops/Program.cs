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

            //Do While Loops
            //int hello = 0;
            //int lengthText = 0;
            //do
            //{
            //    Console.WriteLine("Please enter the name of your friend: ");
            //    string friend = Console.ReadLine();
            //    int currentLength = friend.Length;
            //    lengthText += currentLength;

            //    Console.WriteLine(hello + "hello");
            //    hello++;
            //} while (hello < 20);
            //Console.WriteLine("Thanks, that's engouh!");

            //while loop

            int counter = 0;
            while(counter < 10)
            {
                Console.WriteLine(counter);
                counter++;
            }

            int people = 0;
            string enteredText = "";
            while (enteredText.Equals(""))
            {
                Console.WriteLine("Please press enter to increse amount by one and anything else + enter if you want to finish counting.");
                enteredText = Console.ReadLine();

                people++;
                Console.WriteLine("Current people count is {0}", people);
            }
            Console.Read();

        }
    }
}
