public class AviaryMethods
{
    public static void AnalyzeAnimals(List<Animal> AviaryList)
    {
        if (AviaryList.Count == 0)
        {
            Console.WriteLine("В вольере нет животных!");
            return;
        }

        // Статистика по полу
        int males = AviaryList.Count(a => a.Sex);
        int females = AviaryList.Count - males;

        Console.WriteLine("\n=== Статистика ===");
        Console.WriteLine($"Всего животных: {AviaryList.Count}");
        Console.WriteLine($"Самцов: {males}");
        Console.WriteLine($"Самок: {females}");

        // Вывод информации о каждом животном
        Console.WriteLine("\n=== Подробно ===");
        foreach (var animal in AviaryList)
        {
            Console.WriteLine($"- Звук: {animal.Voice}");
            Console.WriteLine($"  Пол: {animal.SexDisplay}");
            Console.WriteLine($"  Тип: {animal.GetType().Name}");
            Console.WriteLine();
        }
    }
}

public class AnimalsRender
{
    public static List<Animal> RenderAnimals(Dictionary<Func<Animal>, int> creationRules)
    {
        var animalList = new List<Animal>();
        foreach (var rule in creationRules)
        {
            for (int i = 0; i < rule.Value; i++)
            {
                animalList.Add(rule.Key());
            }
        }

        return animalList;
    }
}
