using System.Runtime.Serialization.Formatters.Binary;

namespace IOPractice
{
    internal class Program
    {
        public static string Dir = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        public static string File = "SerializedText.txt";

        static void Main(string[] args)
        {
            SeralizationExample();
            DeserializationExample();
        }

        static void SeralizationExample()
        {
            Employee employee = new Employee()
            {
                Name = "felipe",
                LastName = "zapata",
                PhoneNumber = "04241097674",
                Age = 25,
                DtAdd = DateTime.Now.AddDays(-5),
                CDI = "25706748"
            };

            FileStream stream = new(Dir + File, FileMode.Create);
            BinaryFormatter binaryFormatter = new();
#pragma warning disable SYSLIB0011
            binaryFormatter.Serialize(stream, employee);
#pragma warning restore SYSLIB0011
            stream.Close();
        }

        static void DeserializationExample()
        {
            FileStream stream = new(Dir + File, FileMode.Create);
            Employee employee = null;
            BinaryFormatter binaryFormatter = new();
#pragma warning disable SYSLIB0011
            employee = (Employee)binaryFormatter.Deserialize(stream);
#pragma warning restore SYSLIB0011
            stream.Close();
            Console.WriteLine("Nombre:{0}{1}\nTelefono:{2}\nEdad:{3}\nFecha de Ingreso:{4}\nIdentificacion:{5}", employee.Name, employee.LastName, employee.PhoneNumber, employee.DtAdd, employee.CDI);
            Console.Read();
        }
    }
}