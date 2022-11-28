using Microsoft.CSharp;
using System;
using System.CodeDom.Compiler;
using System.IO;
using ReflectionExamples;

namespace CodeDOM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("/// GetType, GetMethods, GetProperties Ejemplo ///");
            TypeExample example1 = new TypeExample();
            example1.Test();
            Console.WriteLine("/// Uso de Atributos Ejemplo ///");
            BasicAttributeExample example2 = new BasicAttributeExample();
            example2.Test();
            Console.WriteLine("/// CodeDOM Ejemplo ///");
            Console.ReadLine();
            // incluir ejemplo de programa de consola con ese nombre en el desktop para que funcione
            string source1 = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "ConsoleTest.cs");
            var references = new string[] { "System.Dll", "System.Core.Dll" };
            var result = CompilerCSharpSource(new string[] { source1 }, "App.exe", references);
            if (result.Errors.Count == 0)
                Console.WriteLine("No hubo Error, el programa compilado se encuentra en la carpeta de este proyecto");
            else
                foreach (CompilerError item in result.Errors)
                {
                    Console.WriteLine(item.ErrorText);
                }
        }

        public static CompilerResults CompilerCSharpSource(string[] sources, string output, params string[] references)
        {
            var parameters = new CompilerParameters(references, output);
            parameters.GenerateExecutable = true;
            using (var provider = new CSharpCodeProvider())
                return provider.CompileAssemblyFromSource(parameters, sources);
        }
    }
}
