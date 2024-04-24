using TypeTeacher;

using System;

namespace TypeTeacher
{
    class Program
    {
        static void PrintText() {
            Console.WriteLine("Let's check your writing skills!");
            Console.WriteLine("After you hit key timer initiated and your task is to write the text that will be shown above.");
            Console.WriteLine("Hit enter to go!");
            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, %username%!");

            while(true) {
                PrintText();

                Entry entry = new Entry();
                entry.SelectText();
                entry.PrintText();
                DateTime startedAt = DateTime.Now;
                string userText = Console.ReadLine();
                entry.SetUserInput(userText);
                TimeSpan span = DateTime.Now - startedAt;
                entry.SetTime(span);
                entry.PrintStats();
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
