using System;

namespace minutnik
{
    class Program
    {
        static void Main(string[] args)
        {
            int min = 0;
            while (min < 60)
            {
                int sek = 0;
                while (sek < 60)
                {
                    
                    Console.WriteLine($"Minut: {min}, sekund: {sek}");
                    sek++;
                }
                min++;
            }
        }
    }
}
