// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, %username%!");

while(true) {
    DateTime startTime = DateTime.Now;
    Console.WriteLine("Let's check your writing skills!");
    Console.WriteLine("After you hit key timer initiated and your task is to write the text that will be shown above.");
    Console.WriteLine("Hit enter to go!");
    Console.ReadLine();
    Console.WriteLine("Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.");
    DateTime startedAt = DateTime.Now;
    string userText = Console.ReadLine();
    TimeSpan span = DateTime.Now - startedAt;
    Console.WriteLine("Your result is:");
    Console.WriteLine(userText);
    Console.WriteLine("Your time was:");
    Console.WriteLine(span);
    Console.WriteLine("To exit write q. To continue press other key!");
    char userInput = Console.ReadKey().KeyChar;
    if (userInput == 'q') {
        break;
    }
}

Console.WriteLine("See ya!");
