using System.Windows;

namespace Lab7
{
    /// <summary>
    /// Interaction logic for FirstWindow.xaml
    /// </summary>
    public partial class FirstWindow : Window
    {
        public FirstWindow()
        {
            InitializeComponent();
        }

        // EJERCICIO 12 "MI PRIMERA VENTANA"
        private void DisplayNameButton_Click(object sender, RoutedEventArgs e)
        {
            string firstName = NameBox.Text;
            string middleName = MiddleNameBox.Text;
            string lastName = LastNameBox.Text;
            string result = $"{firstName} {middleName} {lastName}";
            MessageBox.Show(result, "MessageBox Sample", MessageBoxButton.OK, MessageBoxImage.Information);

        }
    }
}
