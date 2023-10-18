#nullable disable

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

namespace WpfApp_task1
{
    public partial class MainWindow : Window
    {
        decimal num1 = 0;
        int Index = 0, ext, num2;
        char lastSymbol = ' ';

        public MainWindow()
        {
            InitializeComponent();
        }

        private void General_Click(object sender, RoutedEventArgs e)
        {
            var btn = sender as Button;
            if (textbox1.Text == "00")
                textbox1.Clear();
            textbox1.Text += btn.Content.ToString();
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            if (textbox1.Text != "00")
            {
                textbox1.Text = textbox1.Text.Substring(0, textbox1.Text.Length - 1);
                if (textbox1.Text == "")
                    textbox1.Text = "00";
                textbox1.CaretIndex = textbox1.Text.Length;
            }
        }

        private void Divide_Click(object sender, RoutedEventArgs e)
        {
            Start_Operation();
            lastSymbol = '/';
            textbox1.Text += '/';
        }

        private void Equals_Click(object sender, RoutedEventArgs e)
        {
            Start_Operation();
            lastSymbol = '=';
            textbox1.Text = num1.ToString();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            Start_Operation();
            lastSymbol = '+';
            textbox1.Text += "+";
        }

        private void Multiply(object sender, RoutedEventArgs e)
        {
            Start_Operation();
            lastSymbol = '*';
            textbox1.Text += "x";
        }

        private void Minus(object sender, RoutedEventArgs e)
        {
            Start_Operation();
            lastSymbol = '-';
            textbox1.Text += "-";
        }

        private void Percentage(object sender, RoutedEventArgs e)
        {
            Start_Operation();
            lastSymbol = '%';
            textbox1.Text += "%";
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            textbox1.Text = "00";
            Index = 0;
            num1 = 0;
            lastSymbol = ' ';
        }

        private void Start_Operation()
        {
            if (lastSymbol == '+' || lastSymbol == ' ')
            {
                num1 += decimal.Parse(textbox1.Text.Substring(Index));
            }
            else if (lastSymbol == '-')
            {
                num1 -= decimal.Parse(textbox1.Text.Substring(Index));
            }
            else if (lastSymbol == '*')
            {
                num1 *= decimal.Parse(textbox1.Text.Substring(Index));
            }
            else if (lastSymbol == '/')
            {
                num1 /= decimal.Parse(textbox1.Text.Substring(Index));
            }
            else if (lastSymbol == '%')
            {
                num1 /= 100;
            }
        }
    }
}