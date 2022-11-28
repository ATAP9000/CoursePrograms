using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace ReflectionExamples
{
    public class TypeExample
    {
        public class Account
        {
            public int Number { get; set; }
            public decimal Total { get; set; }

            public Account()
            {
                Total = 0;
            }

            public void Desposit(decimal amount)
            {
                Total += amount;
            }
        }

        public void Test()
        {
            Account account = new Account();
            PropertyInfo[] properties = account.GetType().GetProperties();
            Console.WriteLine("PROPIEDADES del objecto Account");
            foreach (var item in properties)
            {
                Console.WriteLine("Propiedad {0} >> {1}", item.Name, item.PropertyType);
            }
            Console.WriteLine("METODOS del objecto Account");
            MethodInfo[] methods = account.GetType().GetMethods();
            foreach (var item in methods)
            {
                Console.WriteLine("Metodo {0}", item.Name);
            }
            Console.Read();
        }
    }
}
