using System;
using System.Collections.Generic;
using System.Text;

namespace Roulette
{
    class Bets
    {
        public string NumBet(Bin bin)
        {
            return $"Bet on {bin.Number}";
        }

        public string EvenOddBet(Bin bin)
        {
            if (int.Parse(bin.Number) == 0)
            {
                return null;
            }
            else if (int.Parse(bin.Number) % 2 == 0)
            {
                return "Bet on evens";
            }
            else return "Bet on odd";
        }

        public string RedBlackBet(Bin bin)
        {
            if (bin.Number == "0" || bin.Number == "00")
            {
                return null;
            }
            else if (bin.Number == "1" || bin.Number == "3" ||
                bin.Number == "5" || bin.Number == "7" ||
                bin.Number == "9" || bin.Number == "12" ||
                bin.Number == "14" || bin.Number == "16" ||
                bin.Number == "18" || bin.Number == "19" ||
                bin.Number == "21" || bin.Number == "23" ||
                bin.Number == "25" || bin.Number == "27" ||
                bin.Number == "30" || bin.Number == "32" ||
                bin.Number == "34" || bin.Number == "36")
            {
                return "Bet on reds";
            }
            else return "Bet on blacks";
        }

        public string LowHighBet(Bin bin)
        {
            if (int.Parse(bin.Number) == 0)
            {
                return null;
            }
            else if (int.Parse(bin.Number) <= 18 && int.Parse(bin.Number) > 0)
            {
                return "Bet on lows 1-18";
            }
            else return "Bet on highs 19-36";
        }

        public string DozensBet(Bin bin)
        {
            if (int.Parse(bin.Number) == 0)
            {
                return null;
            }
            else if (int.Parse(bin.Number) <= 12 && int.Parse(bin.Number) > 0)
            {
                return "Bet on first dozen 1-12";
            }
            else if (int.Parse(bin.Number) <= 24 && int.Parse(bin.Number) > 12)
            {
                return "Bet on second dozen 13-24";
            }
            else return "Bet on third dozen 25-36";
        }

        public string ColumnsBet(Bin bin)
        {
            if (int.Parse(bin.Number) == 0)
            {
                return null;
            }
            else if (bin.Number == "1" || bin.Number == "4" ||
                bin.Number == "7" || bin.Number == "10" ||
                bin.Number == "13" || bin.Number == "16" ||
                bin.Number == "19" || bin.Number == "22" ||
                bin.Number == "25" || bin.Number == "28" ||
                bin.Number == "31" || bin.Number == "34")
            {
                return "Bet on first column";
            }
            else if (bin.Number == "2" || bin.Number == "5" ||
                bin.Number == "8" || bin.Number == "11" ||
                bin.Number == "14" || bin.Number == "17" ||
                bin.Number == "20" || bin.Number == "23" ||
                bin.Number == "26" || bin.Number == "29" ||
                bin.Number == "32" || bin.Number == "35")
            {
                return "Bet on second column";
            }
            else return "Bet on third column";
        }

        public string StreetBet(Bin bin)
        {
            if (int.Parse(bin.Number) == 0)
            {
                return null;
            }
            else if (int.Parse(bin.Number) >= 1 && int.Parse(bin.Number) <= 3)
            {
                return "Bet on first street 1-3";
            }
            else if (int.Parse(bin.Number) >= 4 && int.Parse(bin.Number) <= 6)
            {
                return "Bet on second street 4-6";
            }
            else if (int.Parse(bin.Number) >= 7 && int.Parse(bin.Number) <= 9)
            {
                return "Bet on third street 7-9";
            }
            else if (int.Parse(bin.Number) >= 10 && int.Parse(bin.Number) <= 12)
            {
                return "Bet on fourth street 10-12";
            }
            else if (int.Parse(bin.Number) >= 13 && int.Parse(bin.Number) <= 15)
            {
                return "Bet on fifth street 13-15";
            }
            else if (int.Parse(bin.Number) >= 16 && int.Parse(bin.Number) <= 18)
            {
                return "Bet on sixth street 16-18";
            }
            else if (int.Parse(bin.Number) >= 19 && int.Parse(bin.Number) <= 21)
            {
                return "Bet on seventh street 19-21";
            }
            else if (int.Parse(bin.Number) >= 22 && int.Parse(bin.Number) <= 24)
            {
                return "Bet on eighth street 22-24";
            }
            else if (int.Parse(bin.Number) >= 25 && int.Parse(bin.Number) <= 27)
            {
                return "Bet on ninth street 25-27";
            }
            else if (int.Parse(bin.Number) >= 28 && int.Parse(bin.Number) <= 30)
            {
                return "Bet on tenth street 28-30";
            }
            else if (int.Parse(bin.Number) >= 31 && int.Parse(bin.Number) <= 33)
            {
                return "Bet on 11th street 31-33";
            }
            else return "Bet on last street 34-36";
        }

        public string SixNumberBet(Bin bin)
        {
            if (int.Parse(bin.Number) == 0)
            {
                return null;
            }
            else if (int.Parse(bin.Number) >= 1 && int.Parse(bin.Number) <= 6)
            {
                return "Bet on first six number 1-6";
            }
            else if (int.Parse(bin.Number) >= 7 && int.Parse(bin.Number) <= 12)
            {
                return "Bet on second six number 7-12";
            }
            else if (int.Parse(bin.Number) >= 13 && int.Parse(bin.Number) <= 18)
            {
                return "Bet on third six number 13-18";
            }
            else if (int.Parse(bin.Number) >= 19 && int.Parse(bin.Number) <= 24)
            {
                return "Bet on fourth six number 19-24";
            }
            else if (int.Parse(bin.Number) >= 25 && int.Parse(bin.Number) <= 30)
            {
                return "Bet on fifth six number 25-30";
            }
            else return "Bet on last six number 31-36";
        }

        public string SplitBet(Bin bin)
        {
            string splitBets = "";
            if (bin.Number == "0")
            {
                splitBets += "Split bet on 0/00";
                splitBets += "\nSplit bet on 0/1";
                splitBets += "\nSplit bet on 0/2";
            }
            else if (bin.Number == "00")
            {
                splitBets += "Split bet on 0/00";
                splitBets += "\nSplit bet on 00/2";
                splitBets += "\nSplit bet on 00/3";
            }
            else if (bin.Number == "1")
            {
                splitBets += "Split bet on 0/1";
                splitBets += "\nSplit bet on 1/2";
                splitBets += "\nSplit bet on 1/4";
            }
            else if (bin.Number == "2")
            {
                splitBets += "Split bet on 0/2";
                splitBets += "\nSplit bet on 1/2";
                splitBets += "\nSplit bet on 2/3";
                splitBets += "\nSplit bet on 2/5";
            }
            else if (bin.Number == "3")
            {
                splitBets += "Split bet on 00/3";
                splitBets += "\nSplit bet on 2/3";
                splitBets += "\nSplit bet on 3/6";
            }
            else if (bin.Number == "34")
            {
                splitBets += "Split bet on 31/34";
                splitBets += "\nSplit bet on 34/35";
            }
            else if (bin.Number == "35")
            {
                splitBets += "Split bet on 32/35";
                splitBets += "\nSplit bet on 34/35";
                splitBets += "\nSplit bet on 35/36";
            }
            else if (bin.Number == "36")
            {
                splitBets += "\nSplit bet on 33/36";
                splitBets += "\nSplit bet on 35/36";
            }
            else if (bin.Number == "4" || bin.Number == "7" ||
                bin.Number == "10" || bin.Number == "13" ||
                bin.Number == "16" || bin.Number == "19" ||
                bin.Number == "22" || bin.Number == "25" ||
                bin.Number == "28" || bin.Number == "31")
            {
                splitBets += $"Split bet on {int.Parse(bin.Number) - 3}, {bin.Number}";
                splitBets += $"\nSplit bet on {bin.Number}, {int.Parse(bin.Number) + 1}";
                splitBets += $"\nSplit bet on {bin.Number}, {int.Parse(bin.Number) + 3}";
            }
            else if (bin.Number == "5" || bin.Number == "8" ||
                bin.Number == "11" || bin.Number == "14" ||
                bin.Number == "17" || bin.Number == "20" ||
                bin.Number == "23" || bin.Number == "26" ||
                bin.Number == "29" || bin.Number == "32")
            {
                splitBets += $"Split bet on {int.Parse(bin.Number) - 3}, {bin.Number}";
                splitBets += $"\nSplit bet on {int.Parse(bin.Number) - 1}, {bin.Number}";
                splitBets += $"\nSplit bet on {bin.Number}, {int.Parse(bin.Number) + 1}";
                splitBets += $"\nSplit bet on {bin.Number}, {int.Parse(bin.Number) + 3}";
            }
            else if (bin.Number == "6" || bin.Number == "9" ||
                bin.Number == "12" || bin.Number == "15" ||
                bin.Number == "18" || bin.Number == "21" ||
                bin.Number == "24" || bin.Number == "27" ||
                bin.Number == "30" || bin.Number == "33")
            {
                splitBets += $"Split bet on {int.Parse(bin.Number) - 3}, {bin.Number}";
                splitBets += $"\nSplit bet on {int.Parse(bin.Number) - 1}, {bin.Number}";
                splitBets += $"\nSplit bet on {bin.Number}, {int.Parse(bin.Number) + 3}";
            }
            return splitBets;
        }

        public string CornerBets(Bin bin)
        {
            string cornerBets = "";

            if (bin.Number == "0")
            {
                cornerBets += "Corner bet on 0/1/2";
                cornerBets += "\nCorner bet on 0/00/2";
                return cornerBets;
            }
            else if (bin.Number == "00")
            {
                cornerBets += "Corner bet on 0/00/2";
                cornerBets += "\nCorner bet on 00/2/3";
                return cornerBets;
            }
            else if (bin.Number == "1")
            {
                cornerBets += "Corner bet on 0/1/2";
                cornerBets += "\nCorner bet on 1/2/4/5";
            }
            else if (bin.Number == "2")
            {
                cornerBets += "Corner bet on 0/1/2";
                cornerBets += "\nCorner bet on 00/2/3";
                cornerBets += "\nCorner bet on 1/2/4/5";
                cornerBets += "\nCorner bet on 2/3/5/6";
            }
            else if (bin.Number == "3")
            {
                cornerBets += "Corner bet on 00/2/3";
                cornerBets += "\nCorner bet on 2/3/5/6";
            }
            else if (bin.Number == "34")
            {
                cornerBets += "\nCorner bet on 31/32/34/35";
            }
            else if (bin.Number == "35")
            {
                cornerBets += "Corner bet on 31/32/34/35";
                cornerBets += "\nCorner bet on 32/33/35/36";
            }
            else if (bin.Number == "36")
            {
                cornerBets += "Corner bet on 32/33/35/36";
            }
            else if (bin.Number == "4" || bin.Number == "7" ||
                bin.Number == "10" || bin.Number == "13" ||
                bin.Number == "16" || bin.Number == "19" ||
                bin.Number == "22" || bin.Number == "25" ||
                bin.Number == "28" || bin.Number == "31")
            {
                cornerBets += $"Corner bet on {int.Parse(bin.Number) - 3}, {int.Parse(bin.Number) - 2}, {bin.Number}, {int.Parse(bin.Number) + 1}";
                cornerBets += $"\nCorner bet on {bin.Number}, {int.Parse(bin.Number) + 1}, {int.Parse(bin.Number) + 3}, {int.Parse(bin.Number) + 4}";
            }
            else if (bin.Number == "5" || bin.Number == "8" ||
                bin.Number == "11" || bin.Number == "14" ||
                bin.Number == "17" || bin.Number == "20" ||
                bin.Number == "23" || bin.Number == "26" ||
                bin.Number == "29" || bin.Number == "32")
            {
                cornerBets += $"Corner bet on {int.Parse(bin.Number) - 4}, {int.Parse(bin.Number) - 3}, {int.Parse(bin.Number) - 1}, {bin.Number}";
                cornerBets += $"\nCorner bet on {int.Parse(bin.Number) - 3}, {int.Parse(bin.Number) - 2}, {bin.Number}, {int.Parse(bin.Number) + 1}";
                cornerBets += $"\nCorner bet on {int.Parse(bin.Number) - 1}, {bin.Number}, {int.Parse(bin.Number) + 2}, {int.Parse(bin.Number) + 3}";
                cornerBets += $"\nCorner bet on {bin.Number}, {int.Parse(bin.Number) + 1}, {int.Parse(bin.Number) + 3}, {int.Parse(bin.Number) + 4}";
            }
            else if (bin.Number == "6" || bin.Number == "9" ||
                bin.Number == "12" || bin.Number == "15" ||
                bin.Number == "18" || bin.Number == "21" ||
                bin.Number == "24" || bin.Number == "27" ||
                bin.Number == "30" || bin.Number == "33")
            {
                cornerBets += $"Corner bet on {int.Parse(bin.Number) - 4}, {int.Parse(bin.Number) - 3}, {int.Parse(bin.Number) - 1}, {bin.Number}";
                cornerBets += $"\nCorner bet on {int.Parse(bin.Number) - 1}, {bin.Number}, {int.Parse(bin.Number) + 2}, {int.Parse(bin.Number) + 3}";
            }

            return cornerBets;
        }
    }
}
