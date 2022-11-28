#nullable disable
namespace ThirdExercise
{
    public class Employee : Person
    {
        private double _salary;
        public double Salary { get => _salary; set => _salary = value; }

        public Employee(string name,int age,double salary) : base(name,age)
        {
            Salary = salary;
        }

        public override void Print()
            => Console.WriteLine("Mi Salario estima unos {0} Bolivares",Salary);
    }
}
