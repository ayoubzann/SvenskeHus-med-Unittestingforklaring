using System.Linq;

namespace SvenskeHus
{

   
    public class Program
    {

        static void Main(string[] args)
        {
            List<Hus> Buildings = new List<Hus>();

            Hus Hjem1 = new Hus(1995, 200, "Yellow");
            Console.WriteLine(Hjem1.squareMeters + ", " + Hjem1.color + ", " + Hjem1.buildYear);

            Buildings.Add(Hjem1);

            Hus Hjem2 = new(1985, 350, "Green");
            Console.WriteLine(Hjem2.squareMeters + ", " + Hjem2.color + ", " + Hjem2.buildYear );
            Buildings.Add(Hjem2);

            Skyskraper OsloPlaza = new(2000, 15000, "Blue", 40);
            Console.WriteLine(OsloPlaza.squareMeters + ", " + OsloPlaza.color + ", " + OsloPlaza.buildYear + ", " + OsloPlaza.floors);
            Buildings.Add(OsloPlaza);


            foreach (Hus item in Buildings)                     //For å kalle på alle tingene i lista, så må jeg gi de et navn. Her kalles de for item. 
            {                                                   //Da kalles alle indeksene i lista for item, og hvert hus og skyskraper blir en item. 
                Console.WriteLine(item.buildYear + " " + item.squareMeters + " " + item.color);          

            }

            double totalSquareMeters = Buildings.Sum(item => item.squareMeters);
            Console.WriteLine(totalSquareMeters);

            Console.WriteLine(Hjem1.SquareMeterCost());
            
        }
    }
}