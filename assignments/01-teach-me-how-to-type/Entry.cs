namespace TypeTeacher
{
    enum Language {
        English,
        Russian
    }

    class Entry
    {
        public int TextId { get; private set; }
        public string ActualText { get; private set; }
        public TimeSpan TotalTime { get; private set; }
        public Language CurrentLanguage { get; private set; }

        private static readonly Dictionary<Language, string> firstSegment = new Dictionary<Language, string>()
        {
            {Language.English,"Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum."},
            {Language.Russian,"Lorem Ipsum - это текст-'рыба', часто используемый в печати и вэб-дизайне. Lorem Ipsum является стандартной 'рыбой' для текстов на латинице с начала XVI века. В то время некий безымянный печатник создал большую коллекцию размеров и форм шрифтов, используя Lorem Ipsum для распечатки образцов. Lorem Ipsum не только успешно пережил без заметных изменений пять веков, но и перешагнул в электронный дизайн. Его популяризации в новое время послужили публикация листов Letraset с образцами Lorem Ipsum в 60-х годах и, в более недавнее время, программы электронной вёрстки типа Aldus PageMaker, в шаблонах которых используется Lorem Ipsum."},
        };

        private static  readonly Dictionary<Language, string> secondSegment = new Dictionary<Language, string>()
        {
            {Language.English,"It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English. Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy. Various versions have evolved over the years, sometimes by accident, sometimes on purpose (injected humour and the like)."},
            {Language.Russian,"Давно выяснено, что при оценке дизайна и композиции читаемый текст мешает сосредоточиться. Lorem Ipsum используют потому, что тот обеспечивает более или менее стандартное заполнение шаблона, а также реальное распределение букв и пробелов в абзацах, которое не получается при простой дубликации 'Здесь ваш текст.. Здесь ваш текст.. Здесь ваш текст..' Многие программы электронной вёрстки и редакторы HTML используют Lorem Ipsum в качестве текста по умолчанию, так что поиск по ключевым словам 'lorem ipsum' сразу показывает, как много веб-страниц всё ещё дожидаются своего настоящего рождения. За прошедшие годы текст Lorem Ipsum получил много версий. Некоторые версии появились по ошибке, некоторые - намеренно (например, юмористические варианты)."},
        };

        private static  readonly Dictionary<Language, string> thirdSegment = new Dictionary<Language, string>()
        {
            {Language.English,"Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of 'de Finibus Bonorum et Malorum' (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, 'Lorem ipsum dolor sit amet..', comes from a line in section 1.10.32. The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from 'de Finibus Bonorum et Malorum' by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham."},
            {Language.Russian,"Многие думают, что Lorem Ipsum - взятый с потолка псевдо-латинский набор слов, но это не совсем так. Его корни уходят в один фрагмент классической латыни 45 года н.э., то есть более двух тысячелетий назад. Ричард МакКлинток, профессор латыни из колледжа Hampden-Sydney, штат Вирджиния, взял одно из самых странных слов в Lorem Ipsum, 'consectetur', и занялся его поисками в классической латинской литературе. В результате он нашёл неоспоримый первоисточник Lorem Ipsum в разделах 1.10.32 и 1.10.33 книги 'de Finibus Bonorum et Malorum' ('О пределах добра и зла'), написанной Цицероном в 45 году н.э. Этот трактат по теории этики был очень популярен в эпоху Возрождения. Первая строка Lorem Ipsum, 'Lorem ipsum dolor sit amet..', происходит от одной из строк в разделе 1.10.32. Классический текст Lorem Ipsum, используемый с XVI века, приведён ниже. Также даны разделы 1.10.32 и 1.10.33 'de Finibus Bonorum et Malorum' Цицерона и их английский перевод, сделанный H. Rackham, 1914 год."},
        };

        private static readonly Dictionary<Language, string> fourthSegment = new Dictionary<Language, string>()
        {
            {Language.English,"There are many variations of passages of Lorem Ipsum available, but the majority have suffered alteration in some form, by injected humour, or randomised words which don't look even slightly believable. If you are going to use a passage of Lorem Ipsum, you need to be sure there isn't anything embarrassing hidden in the middle of text. All the Lorem Ipsum generators on the Internet tend to repeat predefined chunks as necessary, making this the first true generator on the Internet. It uses a dictionary of over 200 Latin words, combined with a handful of model sentence structures, to generate Lorem Ipsum which looks reasonable. The generated Lorem Ipsum is therefore always free from repetition, injected humour, or non-characteristic words etc."},
            {Language.Russian,"Есть много вариантов Lorem Ipsum, но большинство из них имеет не всегда приемлемые модификации, например, юмористические вставки или слова, которые даже отдалённо не напоминают латынь. Если вам нужен Lorem Ipsum для серьёзного проекта, вы наверняка не хотите какой-нибудь шутки, скрытой в середине абзаца. Также все другие известные генераторы Lorem Ipsum используют один и тот же текст, который они просто повторяют, пока не достигнут нужный объём. Это делает предлагаемый здесь генератор единственным настоящим Lorem Ipsum генератором. Он использует словарь из более чем 200 латинских слов, а также набор моделей предложений. В результате сгенерированный Lorem Ipsum выглядит правдоподобно, не имеет повторяющихся абзацей или 'невозможных' слов."},
        };

        public List<Dictionary<Language, string>> dictionary = new List<Dictionary<Language, string>>() {
            firstSegment, secondSegment, thirdSegment, fourthSegment
        };

        public void SetLangage(int value)
        {
            CurrentLanguage = (value == 1) ? Language.English : Language.Russian;
        }

        public string SetText()
        {
            Random random = new Random();
            TextId = random.Next(0, dictionary.Count);

            return dictionary[TextId][CurrentLanguage];
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
            Console.WriteLine(dictionary[TextId][CurrentLanguage]);
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

            string text = dictionary[TextId][CurrentLanguage];
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
