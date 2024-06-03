using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace TiCat_Clone
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // INTRODUCTION

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("                             TigerCat National Store");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nWelcome to the Ticat Store\n");
            Console.WriteLine("Please enter your name to continue...");
            Console.ForegroundColor = ConsoleColor.Yellow;
            string username = Console.ReadLine();
            Console.Clear();

            // SETTING VARS

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("                             TigerCat National Store");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nWelcome " + username + "! Lets start with the tickets. How many would you like to order?");
            Console.ForegroundColor = ConsoleColor.Yellow;
            int num1 = int.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nSounds good! Now lets look at the jerseys. How many would you like to order?");
            Console.ForegroundColor = ConsoleColor.Yellow;
            int num2 = int.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nOk. Now how many limited eddition hats would you like to purchase?");
            Console.ForegroundColor = ConsoleColor.Yellow;
            int num3 = int.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nEvery real fan owns a ticat banner! How many would you like to order, " + username + "?");
            Console.ForegroundColor = ConsoleColor.Yellow;
            int num4 = int.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nWe have some great looking footballs. How many would you like to buy?");
            Console.ForegroundColor = ConsoleColor.Yellow;
            int num5 = int.Parse(Console.ReadLine());

            //CHECKOUT CONFIRMATION/CONFIG

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("                             TigerCat National Store");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nOrder Confirmation:");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("-------------------");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.White;

            Console.Write("\nTickets: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("" + num1 + "");

            Console.ForegroundColor = ConsoleColor.White;

            Console.Write("\nJerseys: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("" + num2 + "");

            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("\nHats: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("" + num3 + "");

            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("\nBanners: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("" + num4 + "");

            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("\nFootballs: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("" + num5 + "\n");

            Console.WriteLine("Please press any key to continue....");
            Console.ReadKey();
            Console.Clear();

            // CALCULATIONS

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("                             TigerCat National Store");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("--------------------------------------------------------------------------------");
            double total_bftx = (num1 * 25) + (num2 * 130) + (num3 * 50) + (num4 * 86) + (num5 * 45.90);
            double tx = total_bftx * 0.13;
            double wtx = total_bftx * 1.13;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("\nTotal Before Tax: $");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("" + total_bftx + "");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("\nTax: $");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("" + tx + "");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("\nGrand Total: $");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("" + wtx + "\n\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Thank you for your order and have a great day!   GO TICATS!!!!!!");
        

            /*
             * 
             * 
             *  Console.Clear();
            Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("                             TigerCat National Store");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.White;
            double total_bftx = (num1 * 25) + (num2 * 130) + (num3 * 50) + (num4 * 86) + (num5 * 45.90);
            double tx = total_bftx * 0.13;

        Console.WriteLine("\nHats: " + num3);
        Console.WriteLine("\nBanners: " + num4);
        Console.WriteLine("\nFootballs: " + num5);
    /


        /*
        Console.ReadKey();
        Console.Clear();
        Console.WriteLine("                             TigerCat National Store");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("--------------------------------------------------------------------------------");
        */

        }
    }
}
