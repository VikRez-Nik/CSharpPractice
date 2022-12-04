using System.Xml.Serialization;

XmlSerializer formatter = new XmlSerializer(typeof(Person[]));

List<Person> people = new(); //лист

const string PeopleFilePath = "person.xml";
if (File.Exists(PeopleFilePath))
{
    using FileStream fs = new FileStream(PeopleFilePath, FileMode.Open);
    people.AddRange((Person[])formatter.Deserialize(fs));
}

Console.WriteLine("Привет!");
while (true)
{
    Console.WriteLine("Напиши 1, если хочешь записать внесённые данные или 2, чтобы посмотреть существующие");
    switch (Console.ReadLine())
    {
        case "1": //ввод
            Console.WriteLine("Напиши имя человека");
            string addname = Console.ReadLine();

            Console.WriteLine("Напиши возраст");
            int addage = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine($"Укажи пол. Мужской - m, женский - w");
            Genders addgender = Console.ReadLine() switch
            {
                "m" => Genders.Мужчина,
                "w" => Genders.Женщина,
                _ => Genders.Мужчина
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