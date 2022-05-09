using System;

namespace GuessingGameInfinite
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm genereeib juhuslikku numbrit 1-10;
            //kasutaja peab seda numbrit ära arvama;
            //kui kasutaja suutis seda numbrit ära arvata, siis ta on mängu võitnud;
            //katsete arv on piiramatu
            //*programm genereerib juhuslikku numbrit ühte korda. 

            Console.WriteLine("Võitmiseks tuleb pakkuda arv ühest - kümneni");

            Console.WriteLine("Mängus on teil lõputu arv katseid");

            Random rnd = new Random();
            int AINumber = rnd.Next(1, 11);
            bool LoopActive = true;
            int i = -1;

            while (LoopActive)

            {
                Console.WriteLine("Sisesta vastus: ");
                int HumanNumber = Convert.ToInt32(Console.ReadLine());

                if (HumanNumber == AINumber)
                {
                    Console.WriteLine("Palju Õnne, Olete võitnud!");
                    LoopActive = false;

                }

                else
                {
                    i++;
                    Console.WriteLine($"Vale! Proovi uuesti. Kasutatud katseid: {i + 1}");

                }
            }

            Console.WriteLine("Kena päeva!");

        }
    }
}
    

