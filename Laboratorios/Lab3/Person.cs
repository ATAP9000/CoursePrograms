#nullable disable
namespace ThirdExercise
{
    public class Person
    {
        private string _name;
        private int _age;
        public string Name { get => _name; set => _name = value; }
        public int Age { get => _age; set => _age = value; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public virtual void Print()
            => Console.WriteLine("Hola, soy {0} y tengo {1} Años",Name,Age);
    }
}
