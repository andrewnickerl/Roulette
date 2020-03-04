using System;

/*This program simulates a roulette wheel and returns all the winning
 * bets for each spin of the wheel by using an RNG to generate a Bin
 * object using the Spin method of the Wheel class, and then passing that
 * Bin object to the Wheel class method WinningBets which returns a string
 * of all the winning bets that correspond to that Bin.
 */

namespace Roulette
{
    class Program
    {
        static void Main(string[] args)
        {
            Wheel wheel = new Wheel();
            Bin bin = wheel.Spin(wheel.Numbers, wheel.Colors);

            Console.WriteLine($"The winning bin is {bin.Number}!");
            Console.WriteLine("\nThe winning bets are:\n");
            Console.Write(wheel.WinningBets(bin));
        }
    }
}
