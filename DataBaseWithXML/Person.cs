    public class Person
    {
        public string Name { get; set; } 
        public int Age { get; set; } 
        public Genders Gender { get; set; }
        public Person() { }
    public Person(string name, int age, Genders  gender)
        {
            Name = name;
            Age = age;
            Gender = gender;            
        }
    }
