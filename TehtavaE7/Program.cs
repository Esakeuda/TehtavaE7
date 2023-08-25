using System;

namespace KolmosellaLuvut
{
    class Program
    {
        static void Main(string[] args)
        {
            // Käydään läpi kaikki luvut väliltä 1-99
            for (int luku = 1; luku < 100; luku++)
            {
                // Tarkistetaan, onko luku jaollinen kolmella
                if (luku % 3 == 0)
                {
                    Console.WriteLine(luku);  // Tulostetaan luku, jos se on jaollinen kolmella
                }
            }
        }
    }
}

