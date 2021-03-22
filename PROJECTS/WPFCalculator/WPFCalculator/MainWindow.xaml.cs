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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFCalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    public class Calculator
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static int Sub(int a, int b)
        {
            return a - b;
        }

        public static int Div(int a, int b)
        {
            return a / b;
        }

        public static int Mod(int a, int b)
        {
            return a % b;
        }
    }

    public partial class MainWindow : Window
    {

        long firstNumeric = 0;
        long secondNumeric = 0;
        string operation = null;



        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnPress (object sender, RoutedEventArgs e)
        {
            int value = Int32.Parse((sender as Button).Content.ToString());
            if (operation == null)
            {
                firstNumeric = (firstNumeric * 10) + value;
                txtDisplay.Text = firstNumeric.ToString();

            }
            else
            {
                secondNumeric = (secondNumeric * 10) + value;
                txtDisplay.Text = secondNumeric.ToString();
            }
        }
    }
}
