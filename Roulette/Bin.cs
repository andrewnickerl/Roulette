using System;
using System.Collections.Generic;
using System.Text;

namespace Roulette
{
    class Bin
    {
        public Bin(string number, string color)
        {
            this.Number = number;
            this.Color = color;
        }

        public string Number { get; set; }
        public string Color { get; set; }
    }
}