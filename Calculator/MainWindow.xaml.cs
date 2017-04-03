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

        private void XPower2_Click(object sender, RoutedEventArgs e)
        {
            if (Calculation.Text == "")
                Calculation.Text = "";
            //takes 1st input, converts to double, pultiplies by self, saves in "result", converts back to string, clears window
            else
            {
                result = Convert.ToDouble(Calculation.Text) * Convert.ToDouble(Calculation.Text);
                Calculation.Text = result.ToString();
            }
        }

        private void DivByX_Click(object sender, RoutedEventArgs e)
        {
            if (Calculation.Text == "")
                Calculation.Text = "";
            //takes 1st input, converts to double, divides 1 by double, saves in "result", converts back to string
            else
            {
                result = 1 / Convert.ToDouble(Calculation.Text);
                Calculation.Text = result.ToString();
            }
        }

        private void SqRt_Click(object sender, RoutedEventArgs e)
        {
            if (Calculation.Text == "")
                Calculation.Text = "";
            //takes 1st input, converts to double, divides 1 by double, saves in "result", converts back to string
            else
            {
                Calculation.Text = Math.Sqrt(Convert.ToDouble(Calculation.Text)).ToString();
            }
        }

        //TODO: Fix this method. Currently adds number to end but misses formatting of Button_Click
        private void OnKeyDownHandler(object sender, KeyEventArgs e)
        {
            if (Calculation.Text == "0")
                Calculation.Text = string.Empty;

            if (e.Key == Key.D1)
            {
                Calculation.Text += "1";
            }
            if (e.Key == Key.D2)
            {
                Calculation.Text += "2";
            }
            if (e.Key == Key.D3)
            {
                Calculation.Text += "3";
            }
            if (e.Key == Key.D4)
            {
                Calculation.Text += "4";
            }
            if (e.Key == Key.D5)
            {
                Calculation.Text += "5";
            }
            if (e.Key == Key.D6)
            {
                Calculation.Text += "6";
            }
            if (e.Key == Key.D7)
            {
                Calculation.Text += "7";
            }
            if (e.Key == Key.D8)
            {
                Calculation.Text += "8";
            }
            if (e.Key == Key.D9)
            {
                Calculation.Text += "9";
            }
            if (e.Key == Key.D0)
            {
                Calculation.Text += "0";
            }
            //TODO: Find out how to make symbols work
            //if (e.Key == Key.Add)
            //{
            //    Calculation.Text += "+";
            //}
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
                }
            }
        }

        private void Backspace_Click(object sender, RoutedEventArgs e)
        {
            //if text exists, this function will take off the last int of the strings length
            string str = Calculation.Text;
            int n = str.Length;
            if(n == 0)
            {
                Calculation.Text = "";
            }
            else
            {
                Calculation.Text = str.Substring(0, n - 1);
            }
        }

        private void Point_Click(object sender, RoutedEventArgs e)
        {
            //CE button checks to make sure . has not previously been used and adds it if not
            if (Calculation.Text.Contains("."))
                 Calculation.Text = Calculation.Text;
            else
            {
                Calculation.Text += ".";
            }
        }

        private void C_Click(object sender, RoutedEventArgs e)
        {
            //CE button clears all and resets calculator
            this.Calculation.Text = "";
        }

        private void CE_Click(object sender, RoutedEventArgs e)
        {
            //CE button clears current text in box
            Calculation.Text = string.Empty;
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
