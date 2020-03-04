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
                    winningBets += "Bet on reds";
                    break;
                case "Black":
                    winningBets += "Bet on blacks";
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
                    winningBets += "\nBet on dozen 13-24";
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
                    winningBets += "\nBet on dozen 13-24";
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
                    winningBets += "\nBet on dozen 13-24";
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
                    winningBets += "\nBet on dozen 13-24";
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
                    winningBets += "\nBet on dozen 13-24";
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
                    winningBets += "\nBet on dozen 13-24";
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
                    winningBets += "\nBet on 19";
                    winningBets += "\nBet on odds";
                    winningBets += "\nBet on highs 19-36";
                    winningBets += "\nBet on dozen 13-24";
                    winningBets += "\nBet on first column";
                    winningBets += "\nBet on street 19/20/21";
                    winningBets += "\nBet on 6 number 19/20/21/22/23/24";
                    winningBets += "\nSplit bet on 16/19";
                    winningBets += "\nSplit bet on 19/20";
                    winningBets += "\nSplit bet on 19/22";
                    winningBets += "\nCorner bet on 16/17/19/20";
                    winningBets += "\nCorner bet on 19/20/22/23";
                    break;
                case 20:
                    winningBets += "\nBet on 20";
                    winningBets += "\nBet on evens";
                    winningBets += "\nBet on highs 19-36";
                    winningBets += "\nBet on dozen 13-24";
                    winningBets += "\nBet on second column";
                    winningBets += "\nBet on street 19/20/21";
                    winningBets += "\nBet on 6 number 19/20/21/22/23/24";
                    winningBets += "\nSplit bet on 17/20";
                    winningBets += "\nSplit bet on 19/20";
                    winningBets += "\nSplit bet on 20/21";
                    winningBets += "\nSplit bet on 20/23";                    
                    winningBets += "\nCorner bet on 16/17/19/29";
                    winningBets += "\nCorner bet on 17/18/20/21";
                    winningBets += "\nCorner bet on 19/20/22/23";
                    winningBets += "\nCorner bet on 20/21/23/24";
                    break;
                case 21:
                    winningBets += "\nBet on 21";
                    winningBets += "\nBet on odds";
                    winningBets += "\nBet on highs 19-36";
                    winningBets += "\nBet on dozen 13-24";
                    winningBets += "\nBet on third column";
                    winningBets += "\nBet on street 19/20/21";
                    winningBets += "\nBet on 6 number 19/20/21/22/23/24";
                    winningBets += "\nSplit bet on 18/21";
                    winningBets += "\nSplit bet on 20/21";
                    winningBets += "\nSplit bet on 21/24";
                    winningBets += "\nCorner bet on 17/18/20/21";
                    winningBets += "\nCorner bet on 20/21/23/24";
                    break;
                case 22:
                    winningBets += "\nBet on 22";
                    winningBets += "\nBet on evens";
                    winningBets += "\nBet on highs 19-36";
                    winningBets += "\nBet on dozen 13-24";
                    winningBets += "\nBet on first column";
                    winningBets += "\nBet on street 22/23/24";
                    winningBets += "\nBet on 6 number 19/20/21/22/23/24";
                    winningBets += "\nSplit bet on 19/22";
                    winningBets += "\nSplit bet on 22/23";
                    winningBets += "\nSplit bet on 22/25";
                    winningBets += "\nCorner bet on 19/20/22/23";
                    winningBets += "\nCorner bet on 22/23/25/26";
                    break;
                case 23:
                    winningBets += "\nBet on 23";
                    winningBets += "\nBet on odds";
                    winningBets += "\nBet on highs 19-36";
                    winningBets += "\nBet on dozen 13-24";
                    winningBets += "\nBet on second column";
                    winningBets += "\nBet on street 22/23/24";
                    winningBets += "\nBet on 6 number 19/20/21/22/23/24";
                    winningBets += "\nSplit bet on 20/23";
                    winningBets += "\nSplit bet on 22/23";
                    winningBets += "\nSplit bet on 23/24";
                    winningBets += "\nSplit bet on 23/26";
                    winningBets += "\nCorner bet on 19/20/22/23";
                    winningBets += "\nCorner bet on 20/21/23/24";
                    winningBets += "\nCorner bet on 22/23/25/26";
                    winningBets += "\nCorner bet on 23/24/26/27";
                    break;
                case 24:
                    winningBets += "\nBet on 24";
                    winningBets += "\nBet on evens";
                    winningBets += "\nBet on highs 19-36";
                    winningBets += "\nBet on dozen 13-24";
                    winningBets += "\nBet on third column";
                    winningBets += "\nBet on street 22/23/24";
                    winningBets += "\nBet on 6 number 19/20/21/22/23/24";
                    winningBets += "\nSplit bet on 21/24";
                    winningBets += "\nSplit bet on 23/24";
                    winningBets += "\nSplit bet on 24/27";
                    winningBets += "\nCorner bet on 20/21/23/24";
                    winningBets += "\nCorner bet on 23/24/26/27";
                    break;
                case 25:
                    winningBets += "\nBet on 25";
                    winningBets += "\nBet on odds";
                    winningBets += "\nBet on highs 19-36";
                    winningBets += "\nBet on dozen 25-36";
                    winningBets += "\nBet on first column";
                    winningBets += "\nBet on street 25/26/27";
                    winningBets += "\nBet on 6 number 25/26/27/28/29/30";
                    winningBets += "\nSplit bet on 22/25";
                    winningBets += "\nSplit bet on 25/26";
                    winningBets += "\nSplit bet on 25/28";
                    winningBets += "\nCorner bet on 22/23/25/26";
                    winningBets += "\nCorner bet on 25/26/28/29";

                    break;
                case 26:
                    winningBets += "\nBet on 26";
                    winningBets += "\nBet on evens";
                    winningBets += "\nBet on highs 19-36";
                    winningBets += "\nBet on dozen 25-36";
                    winningBets += "\nBet on second column";
                    winningBets += "\nBet on street 25/26/27";
                    winningBets += "\nBet on 6 number 25/26/27/28/29/30";
                    winningBets += "\nSplit bet on 23/26";
                    winningBets += "\nSplit bet on 25/26";
                    winningBets += "\nSplit bet on 26/27";
                    winningBets += "\nSplit bet on 26/29";
                    winningBets += "\nCorner bet on 22/23/25/26";
                    winningBets += "\nCorner bet on 23/24/26/27";
                    winningBets += "\nCorner bet on 25/26/28/29";
                    winningBets += "\nCorner bet on 26/27/29/30";
                    break;
                case 27:
                    winningBets += "\nBet on 27";
                    winningBets += "\nBet on odds";
                    winningBets += "\nBet on highs 19-36";
                    winningBets += "\nBet on dozen 25-36";
                    winningBets += "\nBet on third column";
                    winningBets += "\nBet on street 25/26/27";
                    winningBets += "\nBet on 6 number 25/26/27/28/29/30";
                    winningBets += "\nSplit bet on 24/27";
                    winningBets += "\nSplit bet on 26/27";
                    winningBets += "\nSplit bet on 27/30";
                    winningBets += "\nCorner bet on 23/24/26/27";
                    winningBets += "\nCorner bet on 26/27/29/30";
                    break;
                case 28:
                    winningBets += "\nBet on 28";
                    winningBets += "\nBet on evens";
                    winningBets += "\nBet on highs 19-36";
                    winningBets += "\nBet on dozen 25-36";
                    winningBets += "\nBet on first column";
                    winningBets += "\nBet on street 28/29/30";
                    winningBets += "\nBet on 6 number 25/26/27/28/29/30";
                    winningBets += "\nSplit bet on 25/28";
                    winningBets += "\nSplit bet on 28/29";
                    winningBets += "\nSplit bet on 28/31";
                    winningBets += "\nCorner bet on 25/26/28/29";
                    winningBets += "\nCorner bet on 28/29/31/32";
                    break;
                case 29:
                    winningBets += "\nBet on 29";
                    winningBets += "\nBet on odds";
                    winningBets += "\nBet on highs 19-36";
                    winningBets += "\nBet on dozen 25-36";
                    winningBets += "\nBet on second column";
                    winningBets += "\nBet on street 28/29/30";
                    winningBets += "\nBet on 6 number 25/26/27/28/29/30";
                    winningBets += "\nSplit bet on 26/29";
                    winningBets += "\nSplit bet on 28/29";
                    winningBets += "\nSplit bet on 29/30";
                    winningBets += "\nSplit bet on 29/32";
                    winningBets += "\nCorner bet on 25/26/28/29";
                    winningBets += "\nCorner bet on 26/27/29/30";
                    winningBets += "\nCorner bet on 28/29/31/32";
                    winningBets += "\nCorner bet on 29/30/32/33";
                    break;
                case 30:
                    winningBets += "\nBet on 30";
                    winningBets += "\nBet on evens";
                    winningBets += "\nBet on highs 19-36";
                    winningBets += "\nBet on dozen 25-36";
                    winningBets += "\nBet on third column";
                    winningBets += "\nBet on street 28/29/30";
                    winningBets += "\nBet on 6 number 25/26/27/28/29/30";
                    winningBets += "\nSplit bet on 27/30";
                    winningBets += "\nSplit bet on 29/30";
                    winningBets += "\nSplit bet on 30/33";
                    winningBets += "\nCorner bet on 26/27/29/30";
                    winningBets += "\nCorner bet on 29/30/32/33";
                    break;
                case 31:
                    winningBets += "\nBet on 31";
                    winningBets += "\nBet on odds";
                    winningBets += "\nBet on highs 19-36";
                    winningBets += "\nBet on dozen 25-36";
                    winningBets += "\nBet on first column";
                    winningBets += "\nBet on street 31/32/33";
                    winningBets += "\nBet on 6 number 31/32/33/34/35/36";
                    winningBets += "\nSplit bet on 28/31";
                    winningBets += "\nSplit bet on 31/32";
                    winningBets += "\nSplit bet on 31/34";
                    winningBets += "\nCorner bet on 28/29/31/32";
                    winningBets += "\nCorner bet on 31/32/34/35";
                    break;
                case 32:
                    winningBets += "\nBet on 32";
                    winningBets += "\nBet on evens";
                    winningBets += "\nBet on highs 19-36";
                    winningBets += "\nBet on dozen 25-36";
                    winningBets += "\nBet on second column";
                    winningBets += "\nBet on street 31/32/33";
                    winningBets += "\nBet on 6 number 31/32/33/34/35/36";
                    winningBets += "\nSplit bet on 29/32";
                    winningBets += "\nSplit bet on 31/32";
                    winningBets += "\nSplit bet on 32/33";
                    winningBets += "\nSplit bet on 32/35";
                    winningBets += "\nCorner bet on 28/29/31/32";
                    winningBets += "\nCorner bet on 29/30/32/33";
                    winningBets += "\nCorner bet on 31/32/34/35";
                    winningBets += "\nCorner bet on 32/33/35/36";
                    break;
                case 33:
                    winningBets += "\nBet on 33";
                    winningBets += "\nBet on odds";
                    winningBets += "\nBet on highs 19-36";
                    winningBets += "\nBet on dozen 25-36";
                    winningBets += "\nBet on third column";
                    winningBets += "\nBet on street 31/32/33";
                    winningBets += "\nBet on 6 number 31/32/33/34/35/36";
                    winningBets += "\nSplit bet on 30/33";
                    winningBets += "\nSplit bet on 32/33";
                    winningBets += "\nSplit bet on 33/36";
                    winningBets += "\nCorner bet on 29/30/32/33";
                    winningBets += "\nCorner bet on 32/33/35/36";
                    break;
                case 34:
                    winningBets += "\nBet on 34";
                    winningBets += "\nBet on evens";
                    winningBets += "\nBet on highs 19-36";
                    winningBets += "\nBet on dozen 25-36";
                    winningBets += "\nBet on first column";
                    winningBets += "\nBet on street 34/35/36";
                    winningBets += "\nBet on 6 number 31/32/33/34/35/36";
                    winningBets += "\nSplit bet on 31/34";
                    winningBets += "\nSplit bet on 34/35";
                    winningBets += "\nCorner bet on 31/32/34/35";
                    break;
                case 35:
                    winningBets += "\nBet on 35";
                    winningBets += "\nBet on odds";
                    winningBets += "\nBet on highs 19-36";
                    winningBets += "\nBet on dozen 25-36";
                    winningBets += "\nBet on second column";
                    winningBets += "\nBet on street 34/35/36";
                    winningBets += "\nBet on 6 number 31/32/33/34/35/36";
                    winningBets += "\nSplit bet on 32/35";
                    winningBets += "\nSplit bet on 34/35";
                    winningBets += "\nSplit bet on 35/36";
                    winningBets += "\nCorner bet on 31/32/34/35";
                    winningBets += "\nCorner bet on 32/33/35/36";
                    break;
                case 36:
                    winningBets += "\nBet on 36";
                    winningBets += "\nBet on evens";
                    winningBets += "\nBet on highs 19-36";
                    winningBets += "\nBet on dozen 25-36";
                    winningBets += "\nBet on third column";
                    winningBets += "\nBet on street 34/35/36";
                    winningBets += "\nBet on 6 number 31/32/33/34/35/36";
                    winningBets += "\nSplit bet on 33/36";
                    winningBets += "\nSplit bet on 35/36";
                    winningBets += "\nCorner bet on 32/33/35/36";
                    break;
                default:
                    break;
            }
            return winningBets;
        }
    }
}
