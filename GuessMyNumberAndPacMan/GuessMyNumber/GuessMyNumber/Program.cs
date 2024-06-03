using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessMyNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("//Guess the Number//");
            Console.WriteLine("Guess the number from 1-100.");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Good luck and try your best!");
            int y = 26; //Actual Answer
            Console.ForegroundColor = ConsoleColor.White;
            int x = int.Parse(Console.ReadLine()); //Input
            
           
            while (x != y)
            {
                if (x > y)
                {
                    Console.WriteLine("The number you inputed is greater than the number");
                }

                else if (x == 20 || x==21 || x == 22 || x == 23 || x == 24 || x == 25 || x == 26)  //terrible way of doing this
                {
                    Console.WriteLine("You are getting very close to the number, try going slightly above?");
                }

                else
                {
                    Console.WriteLine("The number you inputed is less than the number");
                }

                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Incorrect!");
                Console.ForegroundColor = ConsoleColor.White;
                x = int.Parse(Console.ReadLine());
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Correct!");
            Console.ReadKey();

        }




    }
}
