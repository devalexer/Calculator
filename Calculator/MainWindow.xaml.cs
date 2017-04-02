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
        public MainWindow()
        {
            InitializeComponent();
            this.Title = "Standard Calculator";
        }

        string opr;
        double a, b, result;

        //private void FirstUserInput(object sender, TextChangedEventArgs e)
        //{
        //    //pulls users 1st input from first box
        //    var input1 = this.Input1.Text;
        //}

        //private void SecondUserInput(object sender, TextChangedEventArgs e)
        //{
        //    //pulls users 2nd number input from second box
        //    var input2 = this.Input2.Text;
        //}

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            //takes 1st input, converts to double, saves in "a", attaches operator, clears window
            if (Calculation.Text == "")
                Calculation.Text = "";
            else
            {
                a = double.Parse(Calculation.Text);
                opr = "+";
                Calculation.Text = String.Empty;
            }
        }

        private void Subtract_Click(object sender, RoutedEventArgs e)
        {
            //takes 1st input, converts to double, saves in "a", attaches operator, clears window
            if (Calculation.Text == "")
                Calculation.Text = "";
            else
            {
                a = double.Parse(Calculation.Text);
                opr = "-";
                Calculation.Text = String.Empty;
            }
        }

        private void Mult_Click(object sender, RoutedEventArgs e)
        {
            if (Calculation.Text == "")
                Calculation.Text = "";
            //takes 1st input, converts to double, saves in "a", attaches operator, clears window
            else
            {
                a = double.Parse(Calculation.Text);
                opr = "*";
                Calculation.Text = String.Empty;
            }
        }

        private void Div_Click(object sender, RoutedEventArgs e)
        {
            if (Calculation.Text == "")
                Calculation.Text = "";
            //takes 1st input, converts to double, saves in "a", attaches operator, clears window
            else
            {
                a = double.Parse(Calculation.Text);
                opr = "/";
                Calculation.Text = String.Empty;
            }
        }

        private void Percent_Click(object sender, RoutedEventArgs e)
        {
            if (Calculation.Text == "")
                Calculation.Text = "";
            //takes 1st input, converts to double, saves in "a", attaches operator, clears window
            else
            {
                a = double.Parse(Calculation.Text);
                opr = "%";
                Calculation.Text = String.Empty;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //clears default 0 when numbers are entered
            if (Calculation.Text == "0")
                Calculation.Text = string.Empty;
            
            //for any button with Button_Click event, prints number of that key to Calculation box
            Button button = (Button)sender;
            if ((button == null) || (button.ContentStringFormat == "0"))
                return;

            Calculation.Text += button.Content;
        }

        private void Equals_Click(object sender, RoutedEventArgs e)
        {
            if (Calculation.Text == "")
                Calculation.Text = "";
            else
            {
                b = Convert.ToDouble(Calculation.Text);

                switch (opr)
                {
                    case "+":
                        result = a + b;
                        Calculation.Text = result.ToString();
                        break;

                    case "-":
                        result = a - b;
                        Calculation.Text = result.ToString();
                        break;

                    case "*":
                        result = a * b;
                        Calculation.Text = result.ToString();
                        break;

                    case "/":
                        result = a / b;
                        Calculation.Text = result.ToString();
                        break;

                    case "%":
                        result = a % b;
                        Calculation.Text = result.ToString();
                        break;

                    case "x^2":
                        result = Math.Pow(a, 2);
                        Calculation.Text = result.ToString();
                        break;
                }
            }
        }

        private void CE_Click(object sender, RoutedEventArgs e)
        {
            //CE button clears current text in box
            Calculation.Text = "";
        }

        private void C_Click(object sender, RoutedEventArgs e)
        {
            //CE button clears all and resets calculator
            this.Calculation.Text = "";
        }

        private void PosNeg_Click(object sender, RoutedEventArgs e)
        {
            //toggles positive or negative quality 
            if (Calculation.Text.Contains('-'))
                Calculation.Text.Replace("-", "");
            else
                Calculation.Text = "-" + Calculation.Text;
        }
    }
}
