using System;

namespace Uppgift_4._8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in en sträng!");
            string sträng = Console.ReadLine();
          
            Console.WriteLine("Skriv in exakt två tecken.");
            string karaktärer = Console.ReadLine();
                
            karaktärer.Split("");

            string karaktär1 = karaktärer[0].ToString();
            string karaktär2 = karaktärer[1].ToString();

            if (sträng.Contains(karaktär1) && sträng.Contains(karaktär2))
            {
                Console.WriteLine("Båda tecken finns i strängen");
            }
            else
            {
                Console.WriteLine("Båda karaktärer ingår inte i strängen :(");
            }    
            Console.ReadLine();
        }
    }
}
