using TypeTeacher;

using System;

namespace TypeTeacher
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, %username%!");
            Game game = new Game();

            while(true) {
                game.Introduction();
                game.Train();
                game.OverallStats();

                Console.WriteLine("To exit write q. To continue press other key!");
                char userInput = Console.ReadKey().KeyChar;
                if (userInput == 'q') {
                    break;
                }
            }

            Console.WriteLine("See ya!");
        }

    }
}
