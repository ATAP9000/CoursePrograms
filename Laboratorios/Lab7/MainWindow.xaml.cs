using System.Windows;

namespace Lab7
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int variable = 5;
        char character = 'c';
        string chain = "la nieve es blanca";

        public MainWindow()
        {
            InitializeComponent();
        }

        // EJERCICIO 5, cuando se pulse el boton aparezca la frase "la nieve es blanca sobre este"
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            button1.Content = "La nieve es blanca";
            // EJERCICIO 6, cuando se cambie el texto del boton, deshabilitarlo para impedir su uso
            button1.IsEnabled = false;
        }

        // EJERCICIO 7, despues de pulsar el boton se muestra el mensaje "Hola mundo!!!" en un componente textbox
        private void button2_Click(object sender, RoutedEventArgs e)
        {
            textbox2.Text = "Hola mundo!!!";
        }

        // EJERCICIO 8, Messagebox.Show()
        private void button3_Click(object sender, RoutedEventArgs e)
        {
            // EJERCICIO 9
            MessageBox.Show("Ejemplo 3", "test", MessageBoxButton.YesNoCancel);
        }

        // EJERCICIO 10
        private void button4_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("hello World", "My App", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        // EJERCICIO 11
        private void button5_Click(object sender, RoutedEventArgs e)
        {
            string chain;
            chain = "hola " + textbox5.Text;
            label5.Content = chain;
        }

        // EJERCICIO 12
        private void button6_Click(object sender, RoutedEventArgs e)
        {
            string chain;
            // OBTENEMOS EL STRING DEL TEXTBOX Y SE LO ASIGNAMOS A LA CADENA
            chain = textbox5.Text;
            // MOSTRAMOS UN MESSAGEBOX CON LA CADENA 
            MessageBox.Show(chain, "MessageBox Sample", MessageBoxButton.OK, MessageBoxImage.Information);
            // LA OPERACION SE PAUSA HASTA QUE SE CIERRE EL MESSAGEBOX
            // SUSTITUIMOS EL TEXTO EXISTENTE EN LA CADENA POR "APRENDIENDO C#"
            chain = "Aprendiendo C#";
            // EL MESSAGEBOX AHORA MOSTRARA LA NUEVA CADENA ASIGNADA
            MessageBox.Show(chain, "MessageBox Sample", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        // MUESTRA EJERCICIO 12 "MI PRIMERA VENTANA"
        private void button7_Click(object sender, RoutedEventArgs e)
        {
            FirstWindow p = new FirstWindow();
            p.Show();
        }

        // EJERCICIO 13
        private void button8_Click(object sender, RoutedEventArgs e)
        {
            variable = variable + 1;
            // SE PASA LA VARIABLE A SER UN STRING Y SE LE ASIGNA AL CONTENIDO DEL LABEL 8
            label8.Content = variable.ToString();
        }

        // MUESTRA EJERCICIO 14 "CALCULADORA BASICA"
        private void button9_Click(object sender, RoutedEventArgs e)
        {
            BasicCalculatorWindow p = new BasicCalculatorWindow();
            p.Show();
        }
    }
}
