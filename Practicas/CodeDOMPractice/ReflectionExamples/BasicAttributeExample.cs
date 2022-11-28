using System;
using System.Runtime.InteropServices;

namespace ReflectionExamples
{
    public class BasicAttributeExample
    {
        #region [ USO DE ATRIBUTOS PARA INDICAR ALGO OBSOLETO ]

        [Obsolete]
        public void MyFirstDeprecatedMethod()
            => Console.WriteLine("Llamado a MyFirstDeprecatedMethod()");

        [ObsoleteAttribute]
        public void MySecondDeprecatedMethod()
            => Console.WriteLine("Llamado a MySecondDeprecatedMethod()");

        [Obsolete("No deberias utilizar este metodo")]
        public void MyThirdDeprecatedMethod()
            => Console.WriteLine("Llamado a MyThirdDeprecatedMethod()");

        #endregion

        #region [ USO DE DLLS EXTERNOS ]

        [DllImport("User32.dll", EntryPoint = "MessageBox")]
        public static extern int MessageDialog(int hWnd, string msg, string caption, int msgType);

        #endregion

        public void Test()
        {
            MyFirstDeprecatedMethod();
            MySecondDeprecatedMethod();
            MyThirdDeprecatedMethod();
            MessageDialog(0, "Mensaje aplicativo windows", "DllImport", 0);
            Console.Read();
        }
    }
}
