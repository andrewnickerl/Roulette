using System;

namespace Roulette
{
    class Program
    {
        static void Main(string[] args)
        {
            Wheel wheel = new Wheel();
            Console.WriteLine(wheel.Spin(wheel.Numbers, wheel.Colors).Number);
            Console.WriteLine(wheel.Spin(wheel.Numbers, wheel.Colors).Color);
        }
    }
}
