{
    internal class Program
    {
        public static List<Animal> AviaryList = new List<Animal>();
        private static readonly Random _random = new Random();

        public static void Main()
        {
            Console.WriteLine("Начать? ENTER");
            string input = Console.ReadLine();
            if (input.ToLower() == "")
            {
                Choice();
            }
        }

        public static void Choice()
        {
            Console.Clear();
            Console.WriteLine("Крч вот зоопарк, да? Хошь не хошь войти? ENTER");
            string input = Console.ReadLine();
            if (input.ToLower() == "")
            {
                while (true)
                {
                    Console.WriteLine("Выбирай, на кого хочешь позырить...");
                    Console.WriteLine("1. Тигрята.");
                    Console.WriteLine("2. Бибизяничи.");
                    Console.WriteLine("3. Медведь.");
                    Console.WriteLine("4. ПИЗДЕЦ КАКАЯ ОГРОМНАЯ МЫШЬ (габаритами с медведя).");
                    ConsoleKeyInfo keyInfo = Console.ReadKey(intercept: true);
                    switch (keyInfo.Key)
                    {
                        case ConsoleKey.D1:
                            var tigers = new Dictionary<Func<Animal>, int>
                            {
                                { () => new Tiger(), _random.Next(0, 5) },
                            };
                            AviaryList = AnimalsRender.RenderAnimals(tigers);
                            Console.WriteLine("Ты слышишь... Как... Кто-то... Мяукает?...");
                            Aviary();
                            break;
                        case ConsoleKey.D2:
                            var monkeys = new Dictionary<Func<Animal>, int>
                            {
                                { () => new Monkey(), _random.Next(0, 20) },
                            };
                            AviaryList = AnimalsRender.RenderAnimals(monkeys);
                            Console.WriteLine(
                                "Ты слышишь... Нет... Чуешь... Запах  спермы... Это точно человекоподобное...");
                            Aviary();
                            break;
                        case ConsoleKey.D3:
                            var bears = new Dictionary<Func<Animal>, int>
                            {
                                { () => new Bear(), _random.Next(0, 2) },
                            };
                            AviaryList = AnimalsRender.RenderAnimals(bears);
                            Console.WriteLine("Ты слышишь... Как... Кто-то топотит по полу.");
                            Aviary();
                            break;
                        case ConsoleKey.D4:
                            var bigMouses = new Dictionary<Func<Animal>, int>
                            {
                                { () => new EternalBigMouse(), 1 },
                            };
                            AviaryList = AnimalsRender.RenderAnimals(bigMouses);
                            Console.WriteLine("Ты слышишь... Как... Што-то... ОЧЕНЬ ОГРОМНОЕ... ПИЩИТ...");
                            Aviary();
                            break;
                        default:
                            Console.WriteLine("Не выбрав ничего... Ты в слезах, убегаешь в лес...");
                            Environment.Exit(0);
                            break;
                    }
                }
            }
        }

        private static void Aviary()
        {
            Console.Clear();
            Console.WriteLine("Все-таки хочешь увидеть?...");
            Console.WriteLine("Ну... Смотри! Нажми ENTER");

            // Правильная проверка ввода
            if (Console.ReadKey().Key == ConsoleKey.Enter)
            {
                Console.WriteLine("\n"); // Переход на новую строку
                if (AviaryList.Count > 0)
                {
                    AviaryMethods.AnalyzeAnimals(AviaryList);
                }
                else
                {
                    Console.WriteLine("Никого нет! ВСЕ СДОХЛИ!");
                }
                Console.WriteLine("Молодец! Посмотрел!");
                Main();
            }
        }
    }
}
