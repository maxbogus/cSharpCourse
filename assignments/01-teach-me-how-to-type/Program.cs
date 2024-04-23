// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, %username%!");

while(true) {
    DateTime startTime = DateTime.Now;
    Console.WriteLine("Let's check your writing skills!");
    Console.WriteLine("After you hit key timer initiated and your task is to write the text that will be shown above.");
    Console.WriteLine("Hit enter to go!");
    Console.ReadLine();
    string[] options = new [] { 
        "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
        "Et tortor at risus viverra adipiscing at in tellus integer. Rhoncus aenean vel elit scelerisque mauris pellentesque pulvinar pellentesque habitant. Sed lectus vestibulum mattis ullamcorper velit sed ullamcorper morbi tincidunt. Purus ut faucibus pulvinar elementum integer enim neque. Volutpat odio facilisis mauris sit amet. Enim tortor at auctor urna nunc id cursus metus aliquam. Vitae proin sagittis nisl rhoncus mattis rhoncus urna. Nulla aliquet enim tortor at. Neque vitae tempus quam pellentesque. Id aliquet lectus proin nibh nisl condimentum id. Urna nec tincidunt praesent semper feugiat nibh sed pulvinar proin. Consequat nisl vel pretium lectus quam. Egestas maecenas pharetra convallis posuere morbi leo urna molestie at. Mattis pellentesque id nibh tortor id aliquet lectus proin. Mollis aliquam ut porttitor leo a diam sollicitudin tempor. At imperdiet dui accumsan sit amet nulla. Auctor eu augue ut lectus arcu.",
        "Ullamcorper a lacus vestibulum sed arcu non odio euismod. Feugiat nisl pretium fusce id velit ut tortor pretium viverra. Enim sit amet venenatis urna cursus eget nunc scelerisque. Ultrices vitae auctor eu augue ut. Augue lacus viverra vitae congue eu consequat ac felis donec. Eget velit aliquet sagittis id consectetur purus ut faucibus. Malesuada fames ac turpis egestas sed tempus urna et pharetra. Amet consectetur adipiscing elit duis tristique. Nunc lobortis mattis aliquam faucibus purus in massa tempor nec. Orci phasellus egestas tellus rutrum tellus pellentesque eu tincidunt. Congue eu consequat ac felis donec et odio pellentesque diam. Lorem mollis aliquam ut porttitor leo a diam. Enim ut sem viverra aliquet eget sit amet tellus. Semper viverra nam libero justo laoreet sit amet cursus."
    };
    Random random = new Random();
    int randomIndex = random.Next(0, options.Length);
    Console.WriteLine(options[randomIndex]);
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
