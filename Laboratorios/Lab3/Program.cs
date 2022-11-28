using ThirdExercise;

namespace Lab3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FirstExercise();
            SecondExercise();
        }

        static void FirstExercise()
        {
            Sum sum = new(8, 5);
            Substraction substraction = new(1, 6);
            sum.Operate();
            substraction.Operate();
        }

        static void SecondExercise()
        {
            Person person = new("Pepe", 27);
            Console.WriteLine("Propiedades de persona:\nNombre:{0}\nEdad:{1}", person.Name, person.Age);
            person.Print();
            Employee employee = new("Juan", 31, 100);
            Console.WriteLine("Propiedades de empleado:\nNombre:{0}\nEdad:{1}", employee.Name, employee.Age, employee.Salary);
            employee.Print();
        }
    }
}