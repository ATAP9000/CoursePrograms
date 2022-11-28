using System.Globalization;
using System.Windows;

namespace Lab7
{
    /// <summary>
    /// Interaction logic for BasicCalculatorWindow.xaml
    /// </summary>
    public partial class BasicCalculatorWindow : Window
    {
        enum Operator
        {
            Sum,
            Minus,
            Multiplication,
            Disivion,
            None
        }

        Operator CurrentOperator = Operator.None;
        float CurrentValue = 0.0F;

        public BasicCalculatorWindow()
        {
            InitializeComponent();
        }

        private void clear_Click(object sender, RoutedEventArgs e)
        {
            Display.Text = "0.0";
            CurrentValue = 0.0F;
        }

        private void plus_Click(object sender, RoutedEventArgs e)
        {
            CurrentValue = float.Parse(Display.Text, CultureInfo.InvariantCulture);
            CurrentOperator = Operator.Sum;
            Display.Text = "0.0";
        }

        private void minus_Click(object sender, RoutedEventArgs e)
        {
            CurrentValue = float.Parse(Display.Text, CultureInfo.InvariantCulture);
            CurrentOperator = Operator.Minus;
            Display.Text = "0.0";
        }

        private void multiplication_Click(object sender, RoutedEventArgs e)
        {
            CurrentValue = float.Parse(Display.Text, CultureInfo.InvariantCulture);
            CurrentOperator = Operator.Multiplication;
            Display.Text = "0.0";
        }

        private void division_Click(object sender, RoutedEventArgs e)
        {
            CurrentValue = float.Parse(Display.Text, CultureInfo.InvariantCulture);
            CurrentOperator = Operator.Disivion;
            Display.Text = "0.0";
        }

        private void equals_Click(object sender, RoutedEventArgs e)
        {
            switch (CurrentOperator)
            {
                case Operator.Sum:
                    {
                        CurrentValue = CurrentValue + float.Parse(Display.Text, CultureInfo.InvariantCulture);
                        break;
                    }
                case Operator.Minus:
                    {
                        CurrentValue = CurrentValue - float.Parse(Display.Text, CultureInfo.InvariantCulture);
                        break;
                    }
                case Operator.Multiplication:
                    {
                        CurrentValue = CurrentValue * float.Parse(Display.Text, CultureInfo.InvariantCulture);
                        break;
                    }
                case Operator.Disivion:
                    {
                        CurrentValue = CurrentValue / float.Parse(Display.Text, CultureInfo.InvariantCulture);
                        break;
                    }
                case Operator.None:
                default:
                    {
                        break;
                    }
            }
            Display.Text = CurrentValue.ToString();
            Display.Text = Display.Text.Contains(',') ? Display.Text.Replace(',', '.') : Display.Text;
            CurrentOperator = Operator.None;
        }

        private void point_Click(object sender, RoutedEventArgs e)
        {
            if (Display.Text != "0.0" && !Display.Text.Contains("."))
                Display.Text = Display.Text + ".";
        }


        private void zero_Click(object sender, RoutedEventArgs e)
        {
            if (Display.Text.Length <= 10)
            {
                if (Display.Text != "0.0")
                    Display.Text = Display.Text + "0";
            }
        }

        private void one_Click(object sender, RoutedEventArgs e)
        {
            if (Display.Text.Length <= 10)
            {
                if (Display.Text == "0.0")
                    Display.Text = "1";
                else
                    Display.Text = Display.Text + "1";
            }
        }

        private void two_Click(object sender, RoutedEventArgs e)
        {
            if (Display.Text.Length <= 10)
            {
                if (Display.Text == "0.0")
                    Display.Text = "2";
                else
                    Display.Text = Display.Text + "2";
            }
        }

        private void three_Click(object sender, RoutedEventArgs e)
        {
            if (Display.Text.Length <= 10)
            {
                if (Display.Text == "0.0")
                    Display.Text = "3";
                else
                    Display.Text = Display.Text + "3";
            }
        }

        private void four_Click(object sender, RoutedEventArgs e)
        {
            if (Display.Text.Length <= 10)
            {
                if (Display.Text == "0.0")
                    Display.Text = "4";
                else
                    Display.Text = Display.Text + "4";
            }
        }

        private void five_Click(object sender, RoutedEventArgs e)
        {
            if (Display.Text.Length <= 10)
            {
                if (Display.Text == "0.0")
                    Display.Text = "5";
                else
                    Display.Text = Display.Text + "5";
            }

        }

        private void six_Click(object sender, RoutedEventArgs e)
        {
            if (Display.Text.Length <= 10)
            {
                if (Display.Text.Length <= 10)
                {
                    if (Display.Text == "0.0")
                        Display.Text = "6";
                    else
                        Display.Text = Display.Text + "6";
                }
            }
        }

        private void seven_Click(object sender, RoutedEventArgs e)
        {
            if (Display.Text.Length <= 10)
            {
                if (Display.Text == "0.0")
                    Display.Text = "7";
                else
                    Display.Text = Display.Text + "7";
            }
        }

        private void eight_Click(object sender, RoutedEventArgs e)
        {
            if (Display.Text.Length <= 10)
            {
                if (Display.Text == "0.0")
                    Display.Text = "8";
                else
                    Display.Text = Display.Text + "8";
            }
        }

        private void nine_Click(object sender, RoutedEventArgs e)
        {
            if (Display.Text.Length <= 10)
            {
                if (Display.Text == "0.0")
                    Display.Text = "9";
                else
                    Display.Text = Display.Text + "9";
            }
        }
    }
}
