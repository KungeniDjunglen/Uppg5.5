using System;

namespace Brogram
{
    class Program
    {
        static void Main(string[] args)
        {
            bool gameOn = true;
            string[] svar = { "Det blir så ibland", "Gud vet", "Det var Epstein som låg bakom det",
                "Det finns många i världen som undrar samma sak", "Nummer 15, burgerking foot letuce", "JA", "NEJ", "Möjligtvis",
                "Turkisk Pebbar", "Familjen Wallenberg" };
            Random random = new Random();

            Console.WriteLine("Välkommen til magic 8 ball, ställ din fråga och klotet kommer att svara på den. \nSkriv a när du är klar");
            while (gameOn)
            {
                string question = Console.ReadLine();
                if (question == "a")
                {
                    gameOn = false;
                }
                else
                {
                    Console.WriteLine(svar[random.Next(0, 10)]);
                }
            }
        }
    }
}
