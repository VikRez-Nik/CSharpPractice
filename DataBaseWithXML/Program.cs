using System.Xml.Serialization;
XmlSerializer formatter = new XmlSerializer(typeof(Person[]));
List<Person> people = new(); //в этом была моя проблема, не знал о такой штуке

const string PeopleFilePath = "person.xml";
if (File.Exists(PeopleFilePath))
{
    using FileStream fs = new FileStream(PeopleFilePath, FileMode.Open);
    people.AddRange((Person[])formatter.Deserialize(fs));
}

Console.WriteLine("Привет!");
while (true)
{ 
    try // Try большой, но зато,обрабатывает, как нужно.
    {
        Console.WriteLine("Напиши 1, если хочешь записать внесённые данные или 2, чтобы посмотреть существующие");
        switch (Console.ReadLine())
        {
        case "1": //ввод

        Console.WriteLine("Напиши имя человека");
        string addname = Console.ReadLine();
                if (String.IsNullOrEmpty(addname)) //проверка на пустой ввод
                {
                    Console.WriteLine("Ты ничего не ввёл");
                    break;
                }
                               
        Console.WriteLine("Напиши возраст");
        int addage = Convert.ToInt16(Console.ReadLine());
        

        Console.WriteLine($"Укажи пол. Мужской - m, женский - w. Если ты введешь не то, будет присвоен Мужской пол.");
        Genders addgender = Console.ReadLine()
        switch
        {
        "m" => Genders.Мужчина,
        "w" => Genders.Женщина
        };
        people.Add(new Person(addname, addage, addgender)); //запись 
        using (FileStream fs = new FileStream(PeopleFilePath, FileMode.OpenOrCreate))
        {
        formatter.Serialize(fs, people.ToArray());
        }
        break;
                
        case "2": //вывод
            foreach (var person in people)
                {
                    Console.WriteLine($"Имя: {person.Name}  Возраст: {person.Age}  Пол: {person.Gender}");
                }
            break;
        default:
             {
             Console.WriteLine("Введи 1 или 2");
             break;
             }
        }
    }
    catch
    {
        Console.WriteLine("Ты ввёл не то");
    }
}
    //по поводу вынести в отедльные функции не понял
