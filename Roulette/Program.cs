using System;

namespace Roulette
{
    class Program
    {
        static void Main(string[] args)
        {
            Wheel wheel = new Wheel();
            Bin bin = wheel.Spin(wheel.Numbers, wheel.Colors);
            Console.WriteLine($"The winning bin is {bin.Number}!");
            Console.WriteLine("The winning bets are:");
            Console.Write(wheel.WinningBets(bin));
        }
    }
}
