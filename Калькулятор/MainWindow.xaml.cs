using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Калькулятор
{
    public partial class MainWindow : Window
    {
        public double number;
        public string znak = "";
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            if ((znak == "") || (znak == "."))
            {
                numvvod.Content += "1";
            }
            else
            {
                numvvod.Content = "";
                if (number != 0)
                {
                    numvvod.Content = number;
                }
                numvvod.Content += "1";
                number = (number * 10) + 1;

            }

        }   

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            if ((znak == "") || (znak == "."))
            {
                numvvod.Content += "2";
            }
            else
            {
                numvvod.Content = "";
                if (number != 0)
                    numvvod.Content = number;
                numvvod.Content += "2";
                number = (number * 10) + 2;

            }
        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            if ((znak == "") || (znak == "."))
            {
                numvvod.Content += "3";
            }
            else
            {
                numvvod.Content = "";
                if (number != 0)
                    numvvod.Content = number;
                numvvod.Content += "3";
                number = (number * 10) + 3;

            }
        }

        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            if ((znak == "") || (znak == "."))
            {
                numvvod.Content += "4";
            }
            else
            {
                numvvod.Content = "";
                if (number != 0)
                    numvvod.Content = number;
                numvvod.Content += "4";
                number = (number * 10) + 4;

            }
        }

        private void Button5_Click(object sender, RoutedEventArgs e)
        {
            if ((znak == "") || (znak == "."))
            {
                numvvod.Content += "5";
            }
            else
            {
                numvvod.Content = "";
                if (number != 0)
                    numvvod.Content = number;
                numvvod.Content += "5";
                number = (number * 10) + 5;

            }
        }

        private void Button6_Click(object sender, RoutedEventArgs e)
        {
            if ((znak == "") || (znak == "."))
            {
                numvvod.Content += "6";
            }
            else
            {
                numvvod.Content = "";
                if (number != 0)
                    numvvod.Content = number;
                numvvod.Content += "6";
                number = (number * 10) + 6;

            }
        }

        private void Button7_Click(object sender, RoutedEventArgs e)
        {
            if ((znak == "") || (znak == "."))
            {
                numvvod.Content += "7";
            }
            else
            {
                numvvod.Content = "";
                if (number != 0)
                    numvvod.Content = number;
                numvvod.Content += "7";
                number = (number * 10) + 7;

            }
        }

        private void Button8_Click(object sender, RoutedEventArgs e)
        {
            if ((znak == "") || (znak == "."))
            {
                numvvod.Content += "8";
            }
            else
            {
                numvvod.Content = "";
                if (number != 0)
                    numvvod.Content = number;
                numvvod.Content += "8";
                number = (number * 10) + 8;

            }
        }

        private void Button9_Click(object sender, RoutedEventArgs e)
        {
            if ((znak == "") || (znak == "."))
            {
                numvvod.Content += "9";
            }
            else
            {
                numvvod.Content = "";
                if (number != 0)
                    numvvod.Content = number;
                numvvod.Content += "9";
                number = (number * 10) + 9;

            }
        }

        private void Button10_Click(object sender, RoutedEventArgs e)
        {
            if ((znak == "") || (znak == "."))
            {
                numvvod.Content += "0";
            }
            else
            {
                numvvod.Content = "";
                if (number != 0)
                    numvvod.Content = number;
                numvvod.Content += "0";
                number = (number * 10) + 0;
            }
        }

        private void Button11_Click(object sender, RoutedEventArgs e) 
        {
            double a = Convert.ToDouble(numvvod.Content) * -1;
            numvvod.Content = Convert.ToString(a);
        }
        private void Button12_Click(object sender, RoutedEventArgs e)
        {
            znak = ".";
            string a = Convert.ToString(numvvod.Content);

            if (a.Contains(".") == false)
                numvvod.Content += ".";
        }

        private void ButtonRavno_Click(object sender, RoutedEventArgs e)
        {
            PRIMER.Content += numvvod.Content + "";
            string math = (string)PRIMER.Content;
            PRIMER.Content += " =";
            numvvod.Content = new DataTable().Compute(math, null).ToString();
            PRIMER.Content = 0;
            PRIMER.Content = " ";

        }

        private void ButtonPlus_Click(object sender, RoutedEventArgs e)
        {
            znak = "+";
            PRIMER.Content += numvvod.Content + "+";
            number = 0;

        }

        private void ButtonMinus_Click(object sender, RoutedEventArgs e)
        {
            znak = "-";
            PRIMER.Content += numvvod.Content + "-";
            number = 0;
        }

        private void ButtonUmnoj_Click(object sender, RoutedEventArgs e)
        {
            znak = "*";
            PRIMER.Content += numvvod.Content + "*";
            number = 0;
        }

        private void ButtonDelit_Click(object sender, RoutedEventArgs e)
        {
            znak = "/";
            PRIMER.Content += numvvod.Content + " / ";
            number = 0;
        }

        private void ButtonKoren_Click(object sender, RoutedEventArgs e)
        {
            znak = "√";
            double a = Convert.ToDouble(numvvod.Content);
            PRIMER.Content = $"√({numvvod.Content})";
            a = Math.Sqrt(a);
            a = Math.Round(a, 2);
            numvvod.Content = a;
            PRIMER.Content = 0;
            PRIMER.Content = " ";
        }

        private void ButtonKvadrat_Click(object sender, RoutedEventArgs e)
        {
            znak = "x^2";
            double a = Convert.ToDouble(numvvod.Content);
            PRIMER.Content = $"({numvvod.Content})^2";
            a = (a * a);
            numvvod.Content = a;
            PRIMER.Content = 0;
            PRIMER.Content = " ";
        }

        private void ButtonDrob_Click(object sender, RoutedEventArgs e)
        {
            znak = "1/x";
            double a = Convert.ToDouble(numvvod.Content);
            PRIMER.Content = $"1/({numvvod.Content})";
            a = (1/a);
            a = Math.Round(a, 2);
            numvvod.Content = a;
            PRIMER.Content = 0;
            PRIMER.Content = " ";
        }

        private void ButtonProcent_Click(object sender, RoutedEventArgs e)
        {
            double a = Convert.ToDouble(numvvod.Content) / 100;
            numvvod.Content = Convert.ToString(a);
        }

        private void ButtonCE_Click(object sender, RoutedEventArgs e)
        {
            numvvod.Content = number * 0;
            number = (number * 0);
            numvvod.Content = " ";

        }

        private void ButtonC_Click(object sender, RoutedEventArgs e)
        {
            PRIMER.Content = number * 0;
            number = (number * 0);
            PRIMER.Content = " ";
            numvvod.Content = number * 0;
            numvvod.Content = " ";
        }

        private void ButtonStrelka_Click(object sender, RoutedEventArgs e)
        {

            string a = Convert.ToString(numvvod.Content);
            try
            {
                numvvod.Content = a.Remove(a.Length - 1);
                number = Convert.ToInt32(numvvod.Content);
            }
            catch
            {
                numvvod.Content = "";
                number = 0;
            }
        }

        private void Inzener_Click(object sender, RoutedEventArgs e)
        {
            Window1 window1 = new Window1();
            window1.Show();
            this.Hide();
        }

        private void Programmer_Click(object sender, RoutedEventArgs e)
        {
            Window2 window2 = new Window2();
            window2.Show();
            this.Hide();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(1);
        }
    }
}
