using System;

namespace GuessingGameThreeTries
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm genereeib juhuslikku numbrit 1-10;
            //kasutaja peab seda numbrit ära arvama;
            //kui kasutaja suutis seda numbrit ära arvata, siis ta on mängu võitnud;
            //kasutajal on kolm katset, kui kasutaja ei ole suutnud kolme katsega ära arvata, siis mängu võidab arvuti.
            //*programm genereerib juhuslikku numbrit ühte korda

            Console.WriteLine("Tere tulemast mängima!");

            //Programm genereerib juhuslikku numbrit  1-10
            //Kasutaja peab võitmiseks selle numbri ära arvama
            //Kasutajal on kolm katset
            //Kui kasutaja ei arva numbrit ära on mäng läbi
            //Programm genereerib juhuslikku numbrit üks kord


            Console.WriteLine("Võitmiseks tuleb pakkuda arv ühest - kümneni");

            Console.WriteLine("Mängus on teil kolm katset");

            Random rnd = new Random();
            int AINumber = rnd.Next(1, 11);
            int i = 0;

            while (i < 3)

            {
                Console.WriteLine("Sisesta vastus: ");
                int HumanNumber = Convert.ToInt32(Console.ReadLine());

                if (HumanNumber == AINumber)
                {
                    Console.WriteLine(" Palju Õnne, Olete võitnud!");
                    break;
                }

                else
                {
                    i++;
                    Console.WriteLine($"Vale,proovi uuesti! Katseid jäänud: {3 - (i)}");

                }
            }

            Console.WriteLine("Kena päeva!");
            {

            }
            
        }
    }
}
