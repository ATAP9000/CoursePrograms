using System.Text;

namespace Lab4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FirstExercise();
            SecondExercise();
            ThirdExercise();
            Console.ReadLine();
        }

        #region [ PATH ]
        static string _PATH = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        static string _DESTINYPATH = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

        static string GetValidPath()
        {
            string? folder = string.Empty;
            string? fileName = string.Empty;
            string fullPath = string.Empty;
            while (string.IsNullOrWhiteSpace(folder))
            {
                Console.WriteLine("Indique carpeta a usar");
                folder = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(folder))
                {
                    folder = folder.Trim();
                    if (!Directory.Exists($"{_PATH}\\{folder}"))
                        folder = string.Empty;
                }
            }
            while (string.IsNullOrWhiteSpace(fileName))
            {
                Console.WriteLine("Indique archivo a usar");
                fileName = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(fileName))
                {
                    fileName = fileName.Trim();
                    if (!File.Exists($"{_PATH}\\{folder}\\{fileName}") || !Path.HasExtension($"{_PATH}\\{folder}\\{fileName}"))
                        fileName = string.Empty;
                    else
                        fullPath = $"{_PATH}\\{folder}\\{fileName}";
                }
            }
            if (string.IsNullOrWhiteSpace(fullPath))
                return null;
            else
                return fullPath;
        }
        #endregion

        static void FirstExercise()
        {
            string path = GetValidPath();
            string? currentInput = string.Empty;
            if (string.IsNullOrWhiteSpace(path))
                Console.WriteLine("No se ha podido resolver una direccion valida");
            else
            {
                string[] lines = File.ReadAllLines(path);
                Console.WriteLine("Lineas obtenidas en el texto");
                foreach (string line in lines)
                    Console.WriteLine(line);
                Console.WriteLine("Porfavor inserte cualquier texto tantas veces quiera (No insertar texto terminara el bucle)");
                do
                {
                    currentInput = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(currentInput))
                        Console.WriteLine("Terminado...");
                    else
                        lines.Where(a => a.Contains(currentInput)).ToList().ForEach(b => Console.WriteLine(b));
                } while (!string.IsNullOrWhiteSpace(currentInput));
            }
        }

        static void SecondExercise()
        {
            string? fileName = string.Empty;
            Console.WriteLine("Indique archivo de Origen");
            string originPath = GetValidPath();
            if (string.IsNullOrWhiteSpace(originPath))
                Console.WriteLine("No se ha podido resolver una direccion valida del origen o el destino");
            else
            {

                string[] lines = File.ReadAllLines(originPath);
                if (lines.Length == 0)
                {
                    Console.WriteLine("Archivo de origen no tiene lineas de texto, Terminando...");
                    return;
                }
                string longestString = lines.OrderByDescending(a => a.Length).First();
                Console.WriteLine("Indique el nombre del nuevo archivo");
                while (string.IsNullOrWhiteSpace(fileName))
                {
                    Console.WriteLine("Indique archivo a crear");
                    fileName = Console.ReadLine();
                    if (!string.IsNullOrWhiteSpace(fileName))
                        fileName = fileName.Trim();
                }
                string destinyPath = $"{_DESTINYPATH}\\{fileName}.txt";
                if (File.Exists(destinyPath))
                    Console.WriteLine("Archivo destino ya existe, Terminando...");
                else
                {
                    byte[] bytes = Encoding.UTF8.GetBytes(longestString);
                    FileStream file = new(destinyPath, FileMode.Create);
                    file.Write(bytes, 0, bytes.Length);
                    file.Close();
                }
            }

        }

        static void ThirdExercise()
        {
            string? fileName = string.Empty;
            Console.WriteLine("Indique archivo de Origen");
            string originPath = GetValidPath();
            if (string.IsNullOrWhiteSpace(originPath))
                Console.WriteLine("No se ha podido resolver una direccion valida del origen o el destino");
            else
            {
                string[] lines = File.ReadAllLines(originPath);
                if (lines.Length == 0)
                {
                    Console.WriteLine("Archivo de origen no tiene lineas de texto, Terminando...");
                    return;
                }
                Console.WriteLine("Indique el nombre del nuevo archivo");
                while (string.IsNullOrWhiteSpace(fileName))
                {
                    Console.WriteLine("Indique archivo a crear");
                    fileName = Console.ReadLine();
                    if (!string.IsNullOrWhiteSpace(fileName))
                        fileName = fileName.Trim();
                }
                string destinyPath = $"{_DESTINYPATH}\\{fileName}.txt";
                if (File.Exists(destinyPath))
                    Console.WriteLine("Archivo destino ya existe, Terminando...");
                else
                {
                    using StreamWriter writetext = new(destinyPath);
                    foreach (string line in lines)
                        writetext.WriteLine(line.ToUpper());
                }
            }
        }
    }
}