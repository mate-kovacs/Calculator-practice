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

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        long number1 = 0;
        long number2 = 0;
        string operation = "";


        public MainWindow()
        {
            InitializeComponent();
        }

        private void NumberButtonClick(long digit)
        {
            if (operation == "")
            {
                number1 *= 10;
                number1 += digit;
                txtDisplay.Text = number1.ToString();
            }
            else
            {
                number2 *= 10;
                number2 += digit;
                txtDisplay.Text = number2.ToString();
            }
        }

        private void SetOperation(string operation)
        {
            this.operation = operation;
            txtDisplay.Text = "0";
        }

        private void Btn1_Click(object sender, RoutedEventArgs e)
        {
            NumberButtonClick(1L);
        }

        private void Btn2_Click_1(object sender, RoutedEventArgs e)
        {
            NumberButtonClick(2L);
        }

        private void Btn3_Click(object sender, RoutedEventArgs e)
        {
            NumberButtonClick(3L);
        }

        private void Btn4_Click(object sender, RoutedEventArgs e)
        {
            NumberButtonClick(4L);
        }

        private void Btn5_Click(object sender, RoutedEventArgs e)
        {
            NumberButtonClick(5L);
        }

        private void Btn6_Click(object sender, RoutedEventArgs e)
        {
            NumberButtonClick(6L);
        }

        private void Btn7_Click(object sender, RoutedEventArgs e)
        {
            NumberButtonClick(7L);
        }

        private void Btn8_Click(object sender, RoutedEventArgs e)
        {
            NumberButtonClick(8L);
        }

        private void Btn9_Click(object sender, RoutedEventArgs e)
        {
            NumberButtonClick(9L);
        }

        private void Btn0_Click(object sender, RoutedEventArgs e)
        {
            NumberButtonClick(0L);
        }

        private void BtnPlus_Click(object sender, RoutedEventArgs e)
        {
            SetOperation("+");
        }

        private void BtnMinus_Click(object sender, RoutedEventArgs e)
        {
            SetOperation("-");
        }

        private void BtnTimes_Click(object sender, RoutedEventArgs e)
        {
            SetOperation("*");
        }

        private void BtnDivide_Click(object sender, RoutedEventArgs e)
        {
            SetOperation("/");
        }

        private void BtnEquals_Click(object sender, RoutedEventArgs e)
        {
            long result = 0;
            switch (operation)
            {
                case "+":
                    result = number1 + number2;
                    break;
                case "-":
                    result = number1 - number2;
                    break;
                case "*":
                    result = number1 * number2;
                    break;
                case "/":
                    result = number1 / number2;
                    break;
            }
            txtDisplay.Text = result.ToString();
            number1 = result;
            number2 = 0;
            operation = "";
        }

        private void BtnClearEntry_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = 0;
            }
            else
            {
                number2 = 0;
            }
            txtDisplay.Text = "0";
        }

        private void BtnClear_Click(object sender, RoutedEventArgs e)
        {
            number1 = 0;
            number2 = 0;
            operation = "";
            txtDisplay.Text = "0";
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 /= 10;
                txtDisplay.Text = number1.ToString();
            }
            else
            {
                number2 /= 10;
                txtDisplay.Text = number2.ToString();
            }
        }

        private void BtnPlusMinus_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 *= -1;
                txtDisplay.Text = number1.ToString();
            }
            else
            {
                number2 *= -1;
                txtDisplay.Text = number2.ToString();
            }
        }
    }
}
