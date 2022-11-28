namespace Lab1
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese su Nombre: ");
            string? name = Console.ReadLine();
            Console.WriteLine("Ingrese el Nombre de una Ciudad : ");
            string? city = Console.ReadLine();
            Console.WriteLine($"Hola {name}, bienvenido a {city}");
            Console.WriteLine("Porfavor ingrese el nombre de algun dia de la semana:");
            string? dayName = Console.ReadLine();
            switch (dayName?.ToLower())
            {
                case "lunes":
                case "martes":
                case "miercoles":
                case "jueves":
                case "viernes":
                    Console.WriteLine("Dia Laboral");
                    break;
                case "sabado":
                case "domingo":
                    Console.WriteLine("Fin de semana");
                    break;
                default:
                    Console.WriteLine("Invalido");
                    break;
            }
        }
    }
}