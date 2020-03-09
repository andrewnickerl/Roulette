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

        public string WinningBets(Bin bin)
        {
            Bets bet = new Bets();
            string winningBets = "";

            winningBets += bet.NumBet(bin);
            winningBets += "\n" + bet.EvenOddBet(bin);
            winningBets += "\n" + bet.RedBlackBet(bin);
            winningBets += "\n" + bet.LowHighBet(bin);
            winningBets += "\n" + bet.DozensBet(bin);
            winningBets += "\n" + bet.ColumnsBet(bin);
            winningBets += "\n" + bet.StreetBet(bin);
            winningBets += "\n" + bet.SixNumberBet(bin);
            winningBets += "\n" + bet.SplitBet(bin);
            winningBets += "\n" + bet.CornerBets(bin);
            return winningBets;
        }
    }
}