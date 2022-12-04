using System.Collections.Generic;


namespace Database { 
public class Person
{
    public string Name { get; set; }
    public int Ageyear { get; set; }
    public string Gender { get; set; }
    
}
class Program
{
    public void Main(string[] args)
    {
        Person person1 = new Person { Name = "Viktor", Ageyear = 2006, Gender = "Male"};
        Person person2 = new Person { Name = "Gleb", Ageyear = 2006, Gender = "Male" };
            List<Person> persons= new List<Person> { person1, person2 };
    }
}
}