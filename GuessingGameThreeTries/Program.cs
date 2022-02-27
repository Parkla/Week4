using System;

namespace GuessingGameThreeTries
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm genereerib juhuslikku numbrit 1 kuni 10;
            //kasutaja peab seda numbrit ära arvama;
            //kui kasutaja suutis seda numbrit ära arvata, siis on ta mängu võitnud;
            //kasutajal on kolm katset, kui kasutaja ei ole suutnud kolme katsega numbrit ära arvata, siis mängu võidab arvuti;
            //*programm genereerib juhuslikku numbrit ühe korra;

            Random rnd = new Random();
            int cpuNumber = rnd.Next(1, 11);
            Console.WriteLine("Sisestage number");

            int i = 0;
            
            while(i<3)
            {
                int userNumber = Convert.ToInt32(Console.ReadLine());

                if (userNumber == cpuNumber)
                {
                    Console.WriteLine("Olete võitnud");
                    break;
                }
                else
                {
                    i++;
                    Console.WriteLine($"Vale PIN. { 3 - i} katset on jäänud");
                }
                                                
            }

            Console.WriteLine("Kena päeva!");


        }
    }
}
