using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace test_678
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SortArray_Click(object sender, RoutedEventArgs e)
        {
            string input = inputBox.Text;
            string[] numbers = input.Split(' ');
            double[] array = numbers.Select(double.Parse).ToArray();
            Array.Sort(array, (a, b) => b.CompareTo(a));

            outputText.Text = "Сортировка: " + string.Join(" ", array);
        }
    }
}