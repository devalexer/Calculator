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
            this.Title = "Calculator";
        }
     
        private void FirstUserInput(object sender, TextChangedEventArgs e)
        {
            //pulls users 1st input from first box
            var input1 = this.Input1.Text;
        }

        private void SecondUserInput(object sender, TextChangedEventArgs e)
        {
            //pulls users 2nd number input from second box
            var input2 = this.Input2.Text;
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            //performs addition function
            var button = (Button)sender;
            int total = Int32.Parse(Input1.Text) + Int32.Parse(Input2.Text);
            this.Calculation.Text = total.ToString();
        }

        private void Subtract_Click(object sender, RoutedEventArgs e)
        {
            //performs subtraction function
            int total = Int32.Parse(Input1.Text) - Int32.Parse(Input2.Text);
            this.Calculation.Text = total.ToString();
        }

        private void Mult_Click(object sender, RoutedEventArgs e)
        {
            //performs multiplication function
            int total = Int32.Parse(Input1.Text) * Int32.Parse(Input2.Text);
            this.Calculation.Text = total.ToString();
        }

        private void Div_Click(object sender, RoutedEventArgs e)
        {
            //performs division function
            int total = Int32.Parse(Input1.Text) / Int32.Parse(Input2.Text);
            this.Calculation.Text = total.ToString();
        }

        private void Percent_Click(object sender, RoutedEventArgs e)
        {
            //performs percentage function
            int total = (Int32.Parse(Input1.Text) / Int32.Parse(Input2.Text)) * 100;
            this.Calculation.Text = total.ToString();
        }

    }
}
