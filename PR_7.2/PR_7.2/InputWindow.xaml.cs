using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace PR_7._2
{
    /// <summary>
    /// Логика взаимодействия для InputWindow.xaml
    /// </summary>
    public partial class InputWindow : Window
    {
        public InputWindow()
        {
            InitializeComponent();
        }
        private void Calculate_Click(object sender, RoutedEventArgs e)
        {
            double number1, number2, number3;
            if (Double.TryParse(Number1TextBox.Text, out number1) &&
                Double.TryParse(Number2TextBox.Text, out number2) &&
                Double.TryParse(Number3TextBox.Text, out number3))
            {
                if (SArithmCheckBox.IsChecked == true)
                {
                    double average = Math.Round((number1 + number2 + number3) / 3,3);
                    MessageBox.Show($"Average: {average}");
                }
                if (RangeCheckBox.IsChecked == true)
                {
                    double min = Math.Min(number1, Math.Min(number2, number3));
                    double max = Math.Max(number1, Math.Max(number2, number3));
                    double range = max - min;
                    MessageBox.Show($"Range: {range}");
                }
            }
            else
            {
                MessageBox.Show("Invalid input", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
