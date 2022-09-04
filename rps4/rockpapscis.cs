public static class EnumExtensions // Enum рандом
{
    public static Enum GetRandomEnumValue(this Type t)
    {
        return Enum.GetValues(t)          // get values from Type provided
            .OfType<Enum>()               // casts to Enum
            .OrderBy(e => Guid.NewGuid()) // mess with order of results
            .FirstOrDefault();            // take first item in result
    }
}

public static class Program
{
    public enum rps
    {
        rock,
        paper,
        scissors
    }

    public static void Main()
    {
        while (true)
        {
            Console.WriteLine("Привет! Ты хочешь поиграть в камень ножницы бумага?");
            Console.WriteLine("Тогда выбери свой предмет. r - камень, p - бумага,s - ножницы. ");
            string uv = Console.ReadLine();
            var pcv = typeof(rps).GetRandomEnumValue(); // Рандом из Enum
            string pcvstr = Convert.ToString(pcv); //Перевожу рандом из Enum в string.
            
            //Логика игры. Знаю, что if не лучая идея, но зато простая и работает.  
            if (uv == "r" && pcvstr == "rock") { Console.WriteLine("Ты выбрал камень, и комп выбрал камень. Ничья!"); }
            if (uv == "r" && pcvstr == "paper") { Console.WriteLine("Ты выбрал камень, а комп выбрал бумагу. "); }
            if (uv == "r" && pcvstr == "scissors") { Console.WriteLine("Ты выбрал камень, а комп выбрал ножницы. Ты выйграл!"); }
            if (uv == "p" && pcvstr == "rock") { Console.WriteLine("Ты выбрал бумагу, а комп камень. Ты выйграл!"); }
            if (uv == "p" && pcvstr == "paper") { Console.WriteLine("Ты выбрал бумагу, и комп тоже. Ничья!"); }
            if (uv == "p" && pcvstr == "scissors") { Console.WriteLine("Ты выбрал бумагу, а комп выбрал ножницы. Ты проиграл!"); }
            if (uv == "s" && pcvstr == "rock") { Console.WriteLine("Ты выбрал ножницы, а комп выбрал камень. Ты проиграл!"); }
            if (uv == "s" && pcvstr == "paper") { Console.WriteLine("Ты выбрал ножницы, а комп выбрал бумагу! Ты выйграл!"); }
            if (uv == "s" && pcvstr == "scissors") { Console.WriteLine("Ты выбрал ножицы, и комп выбрал ножницы! Ничья! "); }
        }
    }
}