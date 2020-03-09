using System;
using System.Collections.Generic;
using System.Text;

namespace Roulette
{
    class Wheel
    {
        public Wheel()
        {
            this.Numbers = new string[38];
            for(int i = 0; i < Numbers.Length; i++)
            {
                this.Numbers[i] = $"{i}";
                if(i == Numbers.Length-1)
                {
                    this.Numbers[i] = "00";
                }
            }
            this.Colors = new string[3] { "Red", "Black", null };
        }

        //PROPERTIES
        public string[] Numbers { get; }
        public string[] Colors { get; }

        //returns a Bin object with a number and a color based on RNG of the numbers of the roulette wheel
        public Bin Spin(string[] numbers, string[] colors)
        {
            Random random = new Random();
            string rollNum = numbers[random.Next(numbers.Length)]; //generate random number between 0 and 38 and assign the value of the element in the numbers array at that position to rollNum
            string rollColor = "";
            switch (rollNum)
            {
                case "0":
                    rollColor = colors[2];
                    break;
                case "1":
                    rollColor = colors[0];
                    break;
                case "2":
                    rollColor = colors[1];
                    break;
                case "3":
                    rollColor = colors[0];
                    break;
                case "4":
                    rollColor = colors[1];
                    break;
                case "5":
                    rollColor = colors[0];
                    break;
                case "6":
                    rollColor = colors[1];
                    break;
                case "7":
                    rollColor = colors[0];
                    break;
                case "8":
                    rollColor = colors[1];
                    break;
                case "9":
                    rollColor = colors[0];
                    break;
                case "10":
                    rollColor = colors[1];
                    break;
                case "11":
                    rollColor = colors[1];
                    break;
                case "12":
                    rollColor = colors[0];
                    break;
                case "13":
                    rollColor = colors[1];
                    break;
                case "14":
                    rollColor = colors[0];
                    break;
                case "15":
                    rollColor = colors[1];
                    break;
                case "16":
                    rollColor = colors[0];
                    break;
                case "17":
                    rollColor = colors[1];
                    break;
                case "18":
                    rollColor = colors[0];
                    break;
                case "19":
                    rollColor = colors[0];
                    break;
                case "20":
                    rollColor = colors[1];
                    break;
                case "21":
                    rollColor = colors[0];
                    break;
                case "22":
                    rollColor = colors[1];
                    break;
                case "23":
                    rollColor = colors[0];
                    break;
                case "24":
                    rollColor = colors[1];
                    break;
                case "25":
                    rollColor = colors[0];
                    break;
                case "26":
                    rollColor = colors[1];
                    break;
                case "27":
                    rollColor = colors[0];
                    break;
                case "28":
                    rollColor = colors[1];
                    break;
                case "29":
                    rollColor = colors[1];
                    break;
                case "30":
                    rollColor = colors[0];
                    break;
                case "31":
                    rollColor = colors[1];
                    break;
                case "32":
                    rollColor = colors[0];
                    break;
                case "33":
                    rollColor = colors[1];
                    break;
                case "34":
                    rollColor = colors[0];
                    break;
                case "35":
                    rollColor = colors[1];
                    break;
                case "36":
                    rollColor = colors[0];
                    break;
                case "00":
                    rollColor = colors[2];
                    break;
                default:
                    break;
            }
            return new Bin(rollNum, rollColor);
        }        
    }
}
