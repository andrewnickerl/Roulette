using System;
using System.Collections.Generic;
using System.Text;

namespace Roulette
{
    class Wheel
    {
        public Wheel()
        {
            this.Numbers = new int[38];
            for(int i = 0; i < Numbers.Length; i++)
            {
                this.Numbers[i] = i;
                if(i == Numbers.Length-1)
                {
                    this.Numbers[i] = 0;
                }
            }
            this.Colors = new string[3] { "Red", "Black", null };
        }

        public int[] Numbers { get; }
        public string[] Colors { get; }

        //returns a Bin object with a number and a color based on RNG of the numbers of the roulette wheel
        public Bin Spin(int[] numbers, string[] colors)
        {
            Random random = new Random();
            int rollNum = numbers[random.Next(39)]; //generate random number between 0 and 38 and assign the value of the element in the numbers array at that position to rollNum
            string rollColor = "";
            switch (rollNum)
            {
                case 0:
                    rollColor = colors[2];
                    break;
                case 1:
                    rollColor = colors[0];
                    break;
                case 2:
                    rollColor = colors[1];
                    break;
                case 3:
                    rollColor = colors[0];
                    break;
                case 4:
                    rollColor = colors[1];
                    break;
                case 5:
                    rollColor = colors[0];
                    break;
                case 6:
                    rollColor = colors[1];
                    break;
                case 7:
                    rollColor = colors[0];
                    break;
                case 8:
                    rollColor = colors[1];
                    break;
                case 9:
                    rollColor = colors[0];
                    break;
                case 10:
                    rollColor = colors[1];
                    break;
                case 11:
                    rollColor = colors[1];
                    break;
                case 12:
                    rollColor = colors[0];
                    break;
                case 13:
                    rollColor = colors[1];
                    break;
                case 14:
                    rollColor = colors[0];
                    break;
                case 15:
                    rollColor = colors[1];
                    break;
                case 16:
                    rollColor = colors[0];
                    break;
                case 17:
                    rollColor = colors[1];
                    break;
                case 18:
                    rollColor = colors[0];
                    break;
                case 19:
                    rollColor = colors[0];
                    break;
                case 20:
                    rollColor = colors[1];
                    break;
                case 21:
                    rollColor = colors[0];
                    break;
                case 22:
                    rollColor = colors[1];
                    break;
                case 23:
                    rollColor = colors[0];
                    break;
                case 24:
                    rollColor = colors[1];
                    break;
                case 25:
                    rollColor = colors[0];
                    break;
                case 26:
                    rollColor = colors[1];
                    break;
                case 27:
                    rollColor = colors[0];
                    break;
                case 28:
                    rollColor = colors[1];
                    break;
                case 29:
                    rollColor = colors[1];
                    break;
                case 30:
                    rollColor = colors[0];
                    break;
                case 31:
                    rollColor = colors[1];
                    break;
                case 32:
                    rollColor = colors[0];
                    break;
                case 33:
                    rollColor = colors[1];
                    break;
                case 34:
                    rollColor = colors[0];
                    break;
                case 35:
                    rollColor = colors[1];
                    break;
                case 36:
                    rollColor = colors[0];
                    break;
                default:
                    break;
            }
            return new Bin(rollNum, rollColor);
        }

        public string WinningBets(Bin bin)
        {
            string winningBets = "";

            switch (bin.Color)
            {
                case "Red":
                    winningBets += "\nBet on reds";
                    break;
                case "Black":
                    winningBets += "\nBet on blacks";
                    break;
                case null:
                    break;
            }

            switch (bin.Number)
            {
                case 0:
                    winningBets += "\nBet on 0";
                    winningBets += "\nSplit bet on 0/00";
                    winningBets += "\nSplit bet on 0/1";
                    winningBets += "\nSplit bet on 0/2";
                    winningBets += "\nCorner bet on 0/1/2";
                    winningBets += "\nCorner bet on 0/00/2";
                    winningBets += "\nCorner bet on 00/2/3";
                    break;
                case 1:
                    winningBets += "\nBet on 1";
                    winningBets += "\nBet on odds";
                    winningBets += "\nBet on lows 1-18";
                    winningBets += "\nBet on dozens 1-12";
                    winningBets += "\nBet on first column";
                    winningBets += "\nBet on street 1/2/3";
                    winningBets += "\nBet on 6 number 1/2/3/4/5/6";
                    winningBets += "\nSplit bet on 0/1";
                    winningBets += "\nSplit bet on 1/2";
                    winningBets += "\nSplit bet on 1/4";
                    winningBets += "\nCorner bet on 0/1/2";
                    winningBets += "\nCorner bet on 1/2/4/5";
                    break;
                case 2:
                    winningBets += "\nBet on 2";
                    winningBets += "\nBet on evens";
                    winningBets += "\nBet on lows 1-18";
                    winningBets += "\nBet on dozen 1-12";
                    winningBets += "\nBet on second column";
                    winningBets += "\nBet on street 1/2/3";
                    winningBets += "\nBet on 6 number 1/2/3/4/5/6";
                    winningBets += "\nSplit bet on 0/2";
                    winningBets += "\nSplit bet on 1/2";
                    winningBets += "\nSplit bet on 2/3";
                    winningBets += "\nSplit bet on 2/5";
                    winningBets += "\nCorner bet on 0/1/2";
                    winningBets += "\nCorner bet on 00/2/3";
                    winningBets += "\nCorner bet on 1/2/4/5";
                    winningBets += "\nCorner bet on 2/3/5/6";
                    break;
                case 3:
                    winningBets += "\nBet on 3";
                    winningBets += "\nBet on odds";
                    winningBets += "\nBet on lows 1-18";
                    winningBets += "\nBet on dozen 1-12";
                    winningBets += "\nBet on third column";
                    winningBets += "\nBet on street 1/2/3";
                    winningBets += "\nBet on 6 number 1/2/3/4/5/6";
                    winningBets += "\nSplit bet on 00/3";
                    winningBets += "\nSplit bet on 2/3";
                    winningBets += "\nSplit bet on 3/6";
                    winningBets += "\nCorner bet on 00/2/3";
                    winningBets += "\nCorner bet on 2/3/5/6";
                    break;
                case 4:
                    winningBets += "\nBet on 4";
                    winningBets += "\nBet on evens";
                    winningBets += "\nBet on lows 1-18";
                    winningBets += "\nBet on dozen 1-12";
                    winningBets += "\nBet on first column";
                    winningBets += "\nBet on street 4/5/6";
                    winningBets += "\nBet on 6 number 1/2/3/4/5/6";
                    winningBets += "\nSplit bet on 1/4";
                    winningBets += "\nSplit bet on 4/5";
                    winningBets += "\nSplit bet on 4/7";
                    winningBets += "\nCorner bet on 1/2/4/5";
                    winningBets += "\nCorner bet on 4/5/7/8";
                    break;
                case 5:
                    winningBets += "\nBet on 5";
                    winningBets += "\nBet on odds";
                    winningBets += "\nBet on lows 1-18";
                    winningBets += "\nBet on dozen 1-12";
                    winningBets += "\nBet on second column";
                    winningBets += "\nBet on street 4/5/6";
                    winningBets += "\nBet on 6 number 1/2/3/4/5/6";
                    winningBets += "\nSplit bet on 2/5";
                    winningBets += "\nSplit bet on 4/5";
                    winningBets += "\nSplit bet on 5/6";
                    winningBets += "\nSplit bet on 5/8";
                    winningBets += "\nCorner bet on 1/2/4/5";
                    winningBets += "\nCorner bet on 2/3/5/6";
                    winningBets += "\nCorner bet on 4/5/7/8";
                    winningBets += "\nCorner bet on 5/6/8/9";
                    break;
                case 6:
                    winningBets += "\nBet on 6";
                    winningBets += "\nBet on evens";
                    winningBets += "\nBet on lows 1-18";
                    winningBets += "\nBet on dozen 1-12";
                    winningBets += "\nBet on third column";
                    winningBets += "\nBet on street 4/5/6";
                    winningBets += "\nBet on 6 number 1/2/3/4/5/6";
                    winningBets += "\nSplit bet on 3/6";
                    winningBets += "\nSplit bet on 5/6";
                    winningBets += "\nSplit bet on 6/9";
                    winningBets += "\nCorner bet on 2/3/5/6";
                    winningBets += "\nCorner bet on 5/6/8/9";
                    break;
                case 7:
                    winningBets += "\nBet on 7";
                    winningBets += "\nBet on odds";
                    winningBets += "\nBet on lows 1-18";
                    winningBets += "\nBet on dozen 1-12";
                    winningBets += "\nBet on first column";
                    winningBets += "\nBet on street 7/8/9";
                    winningBets += "\nBet on 6 number 7/8/9/10/11/12";
                    winningBets += "\nSplit bet on 4/7";
                    winningBets += "\nSplit bet on 7/8";
                    winningBets += "\nSplit bet on 7/10";
                    winningBets += "\nCorner bet on 4/5/7/8";
                    winningBets += "\nCorner bet on 7/8/10/11";
                    break;
                case 8:
                    winningBets += "\nBet on 8";
                    winningBets += "\nBet on evens";
                    winningBets += "\nBet on lows 1-18";
                    winningBets += "\nBet on dozen 1-12";
                    winningBets += "\nBet on second column";
                    winningBets += "\nBet on street 7/8/9";
                    winningBets += "\nBet on 6 number 7/8/9/10/11/12";
                    winningBets += "\nSplit bet on 5/8";
                    winningBets += "\nSplit bet on 7/8";
                    winningBets += "\nSplit bet on 8/9";
                    winningBets += "\nSplit bet on 8/11";
                    winningBets += "\nCorner bet on 4/5/7/8";
                    winningBets += "\nCorner bet on 5/6/8/9";
                    winningBets += "\nCorner bet on 7/8/10/11";
                    winningBets += "\nCorner bet on 8/9/11/12";
                    break;
                case 9:
                    winningBets += "\nBet on 9";
                    winningBets += "\nBet on odds";
                    winningBets += "\nBet on lows 1-18";
                    winningBets += "\nBet on dozen 1-12";
                    winningBets += "\nBet on third column";
                    winningBets += "\nBet on street 7/8/9";
                    winningBets += "\nBet on 6 number 7/8/9/10/11/12";
                    winningBets += "\nSplit bet on 6/9";
                    winningBets += "\nSplit bet on 8/9";
                    winningBets += "\nSplit bet on 9/12";
                    winningBets += "\nCorner bet on 5/6/8/9";
                    winningBets += "\nCorner bet on 8/9/11/12";
                    break;
                case 10:
                    winningBets += "\nBet on 10";
                    winningBets += "\nBet on evens";
                    winningBets += "\nBet on lows 1-18";
                    winningBets += "\nBet on dozen 1-12";
                    winningBets += "\nBet on first column";
                    winningBets += "\nBet on street 10/11/12";
                    winningBets += "\nBet on 6 number 7/8/9/10/11/12";
                    winningBets += "\nSplit bet on 7/10";
                    winningBets += "\nSplit bet on 10/11";
                    winningBets += "\nSplit bet on 10/13";
                    winningBets += "\nCorner bet on 7/8/10/11";
                    winningBets += "\nCorner bet on 10/11/13/14";
                    break;
                case 11:
                    winningBets += "\nBet on 11";
                    winningBets += "\nBet on odds";
                    winningBets += "\nBet on lows 1-18";
                    winningBets += "\nBet on dozen 1-12";
                    winningBets += "\nBet on second column";
                    winningBets += "\nBet on street 10/11/12";
                    winningBets += "\nBet on 6 number 7/8/9/10/11/12";
                    winningBets += "\nSplit bet on 8/11";
                    winningBets += "\nSplit bet on 10/11";
                    winningBets += "\nSplit bet on 11/12";
                    winningBets += "\nSplit bet on 11/14";
                    winningBets += "\nCorner bet on 7/8/10/11";
                    winningBets += "\nCorner bet on 8/9/11/12";
                    winningBets += "\nCorner bet on 10/11/13/14";
                    winningBets += "\nCorner bet on 11/12/14/15";
                    break;
                case 12:
                    winningBets += "\nBet on 12";
                    winningBets += "\nBet on evens";
                    winningBets += "\nBet on lows 1-18";
                    winningBets += "\nBet on dozen 1-12";
                    winningBets += "\nBet on third column";
                    winningBets += "\nBet on street 10/11/12";
                    winningBets += "\nBet on 6 number 7/8/9/10/11/12";
                    winningBets += "\nSplit bet on 9/12";
                    winningBets += "\nSplit bet on 11/12";
                    winningBets += "\nSplit bet on 12/15";
                    winningBets += "\nCorner bet on 8/9/11/12";
                    winningBets += "\nCorner bet on 11/12/14/15";
                    break;
                case 13:
                    winningBets += "\nBet on 13";
                    winningBets += "\nBet on odds";
                    winningBets += "\nBet on lows 1-18";
                    winningBets += "\nBet on dozen 12-24";
                    winningBets += "\nBet on first column";
                    winningBets += "\nBet on street 13/14/15";
                    winningBets += "\nBet on 6 number 13/14/15/16/17/18";
                    winningBets += "\nSplit bet on 10/13";
                    winningBets += "\nSplit bet on 13/14";
                    winningBets += "\nSplit bet on 13/16";
                    winningBets += "\nCorner bet on 10/11/13/14";
                    winningBets += "\nCorner bet on 13/14/16/17";
                    break;
                case 14:
                    winningBets += "\nBet on 14";
                    winningBets += "\nBet on evens";
                    winningBets += "\nBet on lows 1-18";
                    winningBets += "\nBet on dozen 12-24";
                    winningBets += "\nBet on second column";
                    winningBets += "\nBet on street 13/14/15";
                    winningBets += "\nBet on 6 number 13/14/15/16/17/18";
                    winningBets += "\nSplit bet on 11/14";
                    winningBets += "\nSplit bet on 13/14";
                    winningBets += "\nSplit bet on 14/15";
                    winningBets += "\nSplit bet on 14/17";
                    winningBets += "\nCorner bet on 10/11/13/14";
                    winningBets += "\nCorner bet on 11/12/14/15";
                    winningBets += "\nCorner bet on 13/14/16/17";
                    winningBets += "\nCorner bet on 14/15/17/18";
                    break;
                case 15:
                    winningBets += "\nBet on 15";
                    winningBets += "\nBet on odds";
                    winningBets += "\nBet on lows 1-18";
                    winningBets += "\nBet on dozen 12-24";
                    winningBets += "\nBet on third column";
                    winningBets += "\nBet on street 13/14/15";
                    winningBets += "\nBet on 6 number 13/14/15/16/17/18";
                    winningBets += "\nSplit bet on 12/15";
                    winningBets += "\nSplit bet on 14/15";
                    winningBets += "\nSplit bet on 15/18";
                    winningBets += "\nCorner bet on 11/12/14/15";
                    winningBets += "\nCorner bet on 14/15/17/18";
                    break;
                case 16:
                    winningBets += "\nBet on 16";
                    winningBets += "\nBet on evens";
                    winningBets += "\nBet on lows 1-18";
                    winningBets += "\nBet on dozen 12-24";
                    winningBets += "\nBet on first column";
                    winningBets += "\nBet on street 16/17/18";
                    winningBets += "\nBet on 6 number 13/14/15/16/17/18";
                    winningBets += "\nSplit bet on 13/16";
                    winningBets += "\nSplit bet on 16/17";
                    winningBets += "\nSplit bet on 16/19";
                    winningBets += "\nCorner bet on 13/14/16/17";
                    winningBets += "\nCorner bet on 16/17/19/20";
                    break;
                case 17:
                    winningBets += "\nBet on 17";
                    winningBets += "\nBet on odds";
                    winningBets += "\nBet on lows 1-18";
                    winningBets += "\nBet on dozen 12-24";
                    winningBets += "\nBet on second column";
                    winningBets += "\nBet on street 16/17/18";
                    winningBets += "\nBet on 6 number 13/14/15/16/17/18";
                    winningBets += "\nSplit bet on 14/17";
                    winningBets += "\nSplit bet on 16/17";
                    winningBets += "\nSplit bet on 17/18";
                    winningBets += "\nSplit bet on 17/20";
                    winningBets += "\nCorner bet on 13/14/16/17";
                    winningBets += "\nCorner bet on 14/15/17/18";
                    winningBets += "\nCorner bet on 16/17/19/29";
                    winningBets += "\nCorner bet on 17/18/20/21";
                    break;
                case 18:
                    winningBets += "\nBet on 18";
                    winningBets += "\nBet on evens";
                    winningBets += "\nBet on lows 1-18";
                    winningBets += "\nBet on dozen 12-24";
                    winningBets += "\nBet on third column";
                    winningBets += "\nBet on street 16/17/18";
                    winningBets += "\nBet on 6 number 13/14/15/16/17/18";
                    winningBets += "\nSplit bet on 15/18";
                    winningBets += "\nSplit bet on 17/18";
                    winningBets += "\nSplit bet on 18/21";
                    winningBets += "\nCorner bet on 14/15/17/18";
                    winningBets += "\nCorner bet on 17/18/20/21";
                    break;
                case 19:
                    rollColor = colors[0];
                    break;
                case 20:
                    rollColor = colors[1];
                    break;
                case 21:
                    rollColor = colors[0];
                    break;
                case 22:
                    rollColor = colors[1];
                    break;
                case 23:
                    rollColor = colors[0];
                    break;
                case 24:
                    rollColor = colors[1];
                    break;
                case 25:
                    rollColor = colors[0];
                    break;
                case 26:
                    rollColor = colors[1];
                    break;
                case 27:
                    rollColor = colors[0];
                    break;
                case 28:
                    rollColor = colors[1];
                    break;
                case 29:
                    rollColor = colors[1];
                    break;
                case 30:
                    rollColor = colors[0];
                    break;
                case 31:
                    rollColor = colors[1];
                    break;
                case 32:
                    rollColor = colors[0];
                    break;
                case 33:
                    rollColor = colors[1];
                    break;
                case 34:
                    rollColor = colors[0];
                    break;
                case 35:
                    rollColor = colors[1];
                    break;
                case 36:
                    rollColor = colors[0];
                    break;
                default:
                    break;
            }
            return winningBets;
        }
    }
}
