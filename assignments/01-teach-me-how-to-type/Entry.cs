namespace TypeTeacher
{
    class Entry
    {
        public int TextId { get; private set; }
        public string ActualText { get; private set; }
        public TimeSpan TotalTime { get; private set; }

        public string[] library = new [] { 
                    "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                    "Et tortor at risus viverra adipiscing at in tellus integer. Rhoncus aenean vel elit scelerisque mauris pellentesque pulvinar pellentesque habitant. Sed lectus vestibulum mattis ullamcorper velit sed ullamcorper morbi tincidunt. Purus ut faucibus pulvinar elementum integer enim neque. Volutpat odio facilisis mauris sit amet. Enim tortor at auctor urna nunc id cursus metus aliquam. Vitae proin sagittis nisl rhoncus mattis rhoncus urna. Nulla aliquet enim tortor at. Neque vitae tempus quam pellentesque. Id aliquet lectus proin nibh nisl condimentum id. Urna nec tincidunt praesent semper feugiat nibh sed pulvinar proin. Consequat nisl vel pretium lectus quam. Egestas maecenas pharetra convallis posuere morbi leo urna molestie at. Mattis pellentesque id nibh tortor id aliquet lectus proin. Mollis aliquam ut porttitor leo a diam sollicitudin tempor. At imperdiet dui accumsan sit amet nulla. Auctor eu augue ut lectus arcu.",
                    "Ullamcorper a lacus vestibulum sed arcu non odio euismod. Feugiat nisl pretium fusce id velit ut tortor pretium viverra. Enim sit amet venenatis urna cursus eget nunc scelerisque. Ultrices vitae auctor eu augue ut. Augue lacus viverra vitae congue eu consequat ac felis donec. Eget velit aliquet sagittis id consectetur purus ut faucibus. Malesuada fames ac turpis egestas sed tempus urna et pharetra. Amet consectetur adipiscing elit duis tristique. Nunc lobortis mattis aliquam faucibus purus in massa tempor nec. Orci phasellus egestas tellus rutrum tellus pellentesque eu tincidunt. Congue eu consequat ac felis donec et odio pellentesque diam. Lorem mollis aliquam ut porttitor leo a diam. Enim ut sem viverra aliquet eget sit amet tellus. Semper viverra nam libero justo laoreet sit amet cursus."
                };

        public string SelectText()
        {
            Random random = new Random();
            TextId = random.Next(0, library.Length);

            return library[TextId];
        }

        public void SetUserInput(string input)
        {
            ActualText = input;
        }

        public void SetTime(TimeSpan time)
        {
            TotalTime = time;
        }

        public void PrintText() {
            Console.WriteLine(library[TextId]);
        }

        public void PrintStats()
        {
            Console.WriteLine("Your text is:");
            Console.WriteLine(ActualText);
            Console.WriteLine("Your time was:");
            Console.WriteLine(TotalTime);

            int errors = 0;

            Dictionary<char, List<int>> originText = new Dictionary<char, List<int>>();
            Dictionary<char, List<int>> actualText = new Dictionary<char, List<int>>();
            for (int index = 0 ; index < ActualText.Length; index++) {
                if (actualText.ContainsKey(ActualText[index])) {
                    actualText[ActualText[index]].Add(index);
                } else {
                    actualText[ActualText[index]] = new List<int>() {index};
                }
            }

            string text = library[TextId];
            for (int index = 0 ; index < text.Length; index++) {
                if (originText.ContainsKey(text[index])) {
                    originText[text[index]].Add(index);
                } else {
                    originText[text[index]] = new List<int>() {index};
                }
            }

            foreach (var (character, indexes) in originText)
            {
                if (!actualText.ContainsKey(character)) {
                    errors += indexes.Count;
                } else {
                    errors += Math.Abs(indexes.Count - actualText[character].Count);
                }
            }

            Console.WriteLine("Errors: ");
            Console.WriteLine(errors);
            Console.WriteLine("Speed of correct text: ");
            Console.WriteLine((ActualText.Length - errors) / (int) TotalTime.TotalSeconds);
        }
    }
}
