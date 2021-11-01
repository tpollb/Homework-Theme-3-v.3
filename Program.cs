using System;

namespace Homework_Theme_3
{
    class Program
    {
        static void Main(string[] args)
        {

            int MaxUserNames = -1;
            int PlayerNumber = 0;

            int i;

            int MinGameNumber = 12;
            int MaxGameNumber = 120;

            var random = new Random();
            int GameNumber;

            int flag = -1;
            int revange = 1;

            //определение количества имён имён
            while (MaxUserNames < 1 || MaxUserNames > 10)
            {
                Console.WriteLine("Enter number of players 1 to 10: ");
                MaxUserNames = int.Parse(Console.ReadLine());
            }

            string[] UserName = new string[MaxUserNames];
            //запись имён

            for (i = 0; i < MaxUserNames; i++)
            {
                Console.WriteLine($"Enter user name {i + 1}");
                UserName[i] = Console.ReadLine();
            }

            while (revange == 1)
            {
                GameNumber = random.Next(MinGameNumber, MaxGameNumber);
                Console.WriteLine($"Game number is: {GameNumber}");

                //основной цикл

                for (i = 0; i < (MaxGameNumber - MinGameNumber); i++)
                {
                    if (flag == MaxUserNames - 1)
                    {
                        flag = 0;
                    }
                    else flag++;

                    //Console.WriteLine($"{flag}");
                    Console.WriteLine($"Player {UserName[flag]} your turn. Enter 1 to 4: ");
                    PlayerNumber = int.Parse(Console.ReadLine());

                    while (PlayerNumber < 1 || PlayerNumber > 4)
                    {
                        Console.WriteLine($"Player {UserName[flag]} your turn. Enter 1 to 4: ");
                        PlayerNumber = int.Parse(Console.ReadLine());
                    }

                    GameNumber = GameNumber - PlayerNumber;
                    Console.WriteLine($"Game number is: {GameNumber}");

                    if (GameNumber <= 0)
                    {
                        Console.WriteLine($"Player {UserName[flag]} win");
                        break;
                    }
                }
                revange = 2;

                while (revange < 0 || revange > 1)
                {
                    Console.WriteLine($"Want a revange? 0 = No, 1 = Yes, type 0 or 1");
                    revange = int.Parse(Console.ReadLine());
                }

                if (revange == 0)
                {
                    break;
                }
            }


            Console.WriteLine($"Game over");
            Console.ReadKey();
        }
    }
}
