using System;
using System.Data;
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

namespace Калькулятор
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public double number;
        public string znak = "";
        public Window1()
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
            PRIMER.Content += numvvod.Content + "/";
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
            a = (1 / a);
            a = Math.Round(a, 2);
            numvvod.Content = a;
            PRIMER.Content = 0;
            PRIMER.Content = " ";
        }

        private void ButtonSin_Click(object sender, RoutedEventArgs e)
        {
            znak = "sin";
            double a = Convert.ToDouble(numvvod.Content);
            PRIMER.Content = $"sin/({numvvod.Content})";
            a = Math.Sin(a);
            a = Math.Round(a, 2);
            numvvod.Content = a;
            PRIMER.Content = 0;
            PRIMER.Content = " ";
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

        private void ButtonCos_Click(object sender, RoutedEventArgs e)
        {
            znak = "cos";
            double a = Convert.ToDouble(numvvod.Content);
            PRIMER.Content = $"cos/({numvvod.Content})";
            a = Math.Cos(a);
            a = Math.Round(a, 2);
            numvvod.Content = a;
            PRIMER.Content = 0;
            PRIMER.Content = " ";
        }

        private void ButtonTG_Click(object sender, RoutedEventArgs e)
        {
            znak = "Tg";
            double a = Convert.ToDouble(numvvod.Content);
            PRIMER.Content = $"Tg/({numvvod.Content})";
            a = Math.Tan(a);
            a = Math.Round(a, 2);
            numvvod.Content = a;
            PRIMER.Content = 0;
            PRIMER.Content = " ";
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

        private void ButtonFactor_Click(object sender, RoutedEventArgs e)
        {
            int a = Convert.ToInt32(numvvod.Content);
            PRIMER.Content += a + "!";
            int f = 1;
            for(int i = 2; i <= a; i++)
            {
                f = f * i;
            }
            numvvod.Content = f;
            PRIMER.Content = 0;
            PRIMER.Content = " ";
        }

        private void ButtonXy_Click(object sender, RoutedEventArgs e)
        {
            znak = "x^y";
            
        }

        private void ButtonModul_Click(object sender, RoutedEventArgs e)
        {
            znak = "|x|";
            double a = Convert.ToDouble(numvvod.Content);
            PRIMER.Content = $"|({numvvod.Content})|";
            a = Math.Abs(a);
            a = Math.Round(a, 2);
            numvvod.Content = a;
            PRIMER.Content = 0;
            PRIMER.Content = " ";
        }

        

        private void ButtonLog_Click(object sender, RoutedEventArgs e)
        {
            znak = "Log";
            double a = Convert.ToDouble(numvvod.Content);
            PRIMER.Content = $"Log/({numvvod.Content})";
            a = Math.Log(a);
            a = Math.Round(a, 2);
            numvvod.Content = a;
            PRIMER.Content = 0;
            PRIMER.Content = " ";
        }

        private void ButtonLn_Click(object sender, RoutedEventArgs e)
        {
            znak = "Ln";
            double a = Convert.ToDouble(numvvod.Content);
            PRIMER.Content = $"Ln/({numvvod.Content})";
            a = Math.Log10(a);
            a = Math.Round(a, 2);
            numvvod.Content = a;
            PRIMER.Content = 0;
            PRIMER.Content = " ";
        }

        private void ButtonPi_Click(object sender, RoutedEventArgs e)
        {
            if ((znak == "") || (znak == "."))
            {
                numvvod.Content += "3.14";
            }
            else
            {
                numvvod.Content = "";
                if (number != 0)
                    numvvod.Content = number;
                numvvod.Content += "3.14";
                number = (number * 10) + 3.14;

            }

        }

        private void ButtonE_Click(object sender, RoutedEventArgs e)
        {
            if ((znak == "") || (znak == "."))
            {
                numvvod.Content += "2.72";
            }
            else
            {
                numvvod.Content = "";
                if (number != 0)
                    numvvod.Content = number;
                numvvod.Content += "2.72";
                number = (number * 10) + 2.72;

            }
        }

        private void Button10x_Click(object sender, RoutedEventArgs e)
        {
            double a = 1;
            double b = Convert.ToDouble(numvvod.Content);
            PRIMER.Content += b + "";
            for(int i = 0; i < b; i++)
            {
                a = a * 10;
            }
            numvvod.Content = a;
            PRIMER.Content = 0;
            PRIMER.Content = " ";
        }

        private void Obichniy_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
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
