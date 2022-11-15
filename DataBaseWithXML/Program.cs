using System.Xml.Serialization;

Person[] people = new Person[]
{
    new Person("Tom", 37),
    new Person("Bob", 41)
};

XmlSerializer formatter = new XmlSerializer(typeof(Person[]));
// сохранение массива в файл
using (FileStream fs = new FileStream("person.xml", FileMode.OpenOrCreate))
{
    formatter.Serialize(fs, people);
}
// восстановление массива из файла
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

public class Person
{
    public string Name { get; set; } = "Undefined";
    public int Age { get; set; } = 1;

    public Person() { }
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
}