using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SvenskeHus
{
    public class Hus
    {
        public int buildYear;
        public int squareMeters;
        public string color;

        public Hus(int byggeÅr, int kvadratMeter, string farge)
        {
            buildYear = byggeÅr;
            squareMeters = kvadratMeter;
            color = farge;
        }

        public int GetSquareMeters()
        {
            if (squareMeters > 0) 
            { 
            Console.WriteLine("Please type in a number that signifies the size of the house in meters");
            var userInput = Int32.Parse(Console.ReadLine());
            return squareMeters = userInput;
            }

            else
            {
                throw new ArgumentOutOfRangeException();
            }
        }

        public int SquareMeterCost()
        {
            int HouseExpensesPrYear = 750000;
            int SquareMeterExpenses = HouseExpensesPrYear / squareMeters / 12;

            return SquareMeterExpenses;
        }
        
    }

    public class Skyskraper : Hus
    {
        public int floors;
        public Skyskraper(int byggeår, int kvadratMeter, string farge, int etasjer) : base(byggeår, kvadratMeter, farge)
        {
            
            floors = etasjer;
        }
    }


}

    

    

