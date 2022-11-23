using System.Xml.Serialization;
using static Person;


while (true)
{

    Console.WriteLine("Привет! Напиши 1, если хочешь записать внесённые данные или 2, чтобы посмотреть существующие");
    int choice = Convert.ToInt16(Console.ReadLine());

    //Массивы 
    Person[] people = new Person[]
    {
    new Person("Tom", 37, "Male"),
    new Person("Bob", 41, "Male"),
    new Person("Bill", 55, "Male")
    };
    //Формат
    XmlSerializer formatter = new XmlSerializer(typeof(Person[]));

    switch (choice)
    {
        case 1: //запись
            using (FileStream fs = new FileStream("person.xml", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, people);
            }
            Console.WriteLine("Новые данные сохранены.");
            break;

        case 2: //вывод
            using (FileStream fs = new FileStream("person.xml", FileMode.OpenOrCreate))
            {
                Person[]? newpeople = formatter.Deserialize(fs) as Person[];

                if (newpeople != null)
                {
                    foreach (Person person in newpeople)
                    {
                        Console.WriteLine($"Name: {person.Name} --- Age: {person.Age}");
                    }
                }
            }
            break;

    }
}








//Готово:
//разобраться с полями добавить пол
//вынести Person в отдельный файл
//Консольное окно с выбором(switch) ( если хотите записать нажмите единичку, если хотите получить записи, нажмите двоичку)
//while true