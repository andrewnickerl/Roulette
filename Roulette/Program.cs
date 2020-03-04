using System;

namespace Roulette
{
    class Program
    {
        static void Main(string[] args)
        {
            bool?[] isRed = new bool?[38];
            for(int i = 0; i < isRed.Length; i++)
            {
                if(i == 0)
                {
                    isRed[i] = null;
                    continue;
                }
                if(i == isRed.Length - 1)
                {
                    isRed[i] = null;
                    continue;
                }
                if(i % 2 == 0)
                {
                    isRed 
                }
            }
        }
    }
}
