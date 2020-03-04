using System;

namespace Roulette
{
    class Program
    {
        static void Main(string[] args)
        {
            Wheel wheel = new Wheel();
            Bin bin = wheel.Spin(wheel.Numbers, wheel.Colors);
            Console.WriteLine(bin.Number + "\n" + bin.Color);            
        }
    }
}
