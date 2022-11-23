public class Person
{
    public string Name { get; set; } = "Undefined";
    public int Age { get; set; } = 1;

    public string Gender { get; set; } = string.Empty;


    public Person() { }
    public Person(string name, int age, string gender)
    {
        Name = name;
        Age = age;
        Gender = gender;

    }
}