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

namespace Калькулятор
{
    /// <summary>
    /// Логика взаимодействия для Window2.xaml
    /// </summary>
    public partial class Window2 : Window

    {

        public Window2()

        {

            InitializeComponent();

        }

        private string results = "";

        private string operation = "";

        private int vibor = 10;

        private void Button_Click_2(object sender, RoutedEventArgs e) => chifra(sender);

        private void chifra(object sender)

        {

            if ((txtDisplay.Text == "0"))

                txtDisplay.Text = "";

            Button num = (Button)sender;

            if (num.Content == ".")

            {

                if (!txtDisplay.Text.Contains("."))

                    txtDisplay.Text = txtDisplay.Text + num.Content;

            }

            else

                txtDisplay.Text = txtDisplay.Text + num.Content;

        }

        private void Button_Click(object sender, RoutedEventArgs e) => chifra(sender);

        private void Button_Click_1(object sender, RoutedEventArgs e) => chifra(sender);

        private void Button_Click_3(object sender, RoutedEventArgs e) => chifra(sender);

        private void Button_Click_4(object sender, RoutedEventArgs e) => chifra(sender);

        private void Button_Click_5(object sender, RoutedEventArgs e) => chifra(sender);

        private void Button_Click_6(object sender, RoutedEventArgs e) => chifra(sender);

        private void Button_Click_7(object sender, RoutedEventArgs e) => chifra(sender);

        private void Button_Click_8(object sender, RoutedEventArgs e) => chifra(sender);

        private void Button_Click_9(object sender, RoutedEventArgs e) => chifra(sender);

        private void Button_Click_10(object sender, RoutedEventArgs e) => chifra(sender);

        private void Button_Click_11(object sender, RoutedEventArgs e) => txtDisplay.Text = "0";

        private void Button_Click_12(object sender, RoutedEventArgs e)

        {

            txtDisplay.Text = "0";

            lblShowUp.Text = "";

        }

        private void Button_Click_13(object sender, RoutedEventArgs e)

        {

            if (txtDisplay.Text.Length > 0)

            {

                txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1, 1);

            }

            if (txtDisplay.Text == "")

            {

                txtDisplay.Text = "0";

            }

        }

        private void Button_Click_14(object sender, RoutedEventArgs e) => deystviya(sender);

        private void Button_Click_15(object sender, RoutedEventArgs e) => deystviya(sender);

        private void Button_Click_16(object sender, RoutedEventArgs e) => deystviya(sender);

        private void Button_Click_17(object sender, RoutedEventArgs e) => deystviya(sender);

        private void deystviya(object sender)

        {

            try

            {

                Button num = (Button)sender;

                if (lblShowUp.Text != "")

                {

                    podschet();

                }

                else

                {

                    operation = (string)num.Content;

                    results = txtDisplay.Text;

                    txtDisplay.Text = "";

                    lblShowUp.Text = Convert.ToString(results) + " " + operation;

                }

            }

            catch

            {

                txtDisplay.Text = "0";

                lblShowUp.Text = "";

            }

        }

        private void podschet()

        {

            try

            {

                if (vibor == 10)

                {

                    lblShowUp.Text = "";

                    switch (operation)

                    {

                        case "+":

                            txtDisplay.Text = (Convert.ToDouble(results) + double.Parse(txtDisplay.Text)).ToString();

                            break;

                        case "-":

                            txtDisplay.Text = (Convert.ToDouble(results) - double.Parse(txtDisplay.Text)).ToString();

                            break;

                        case "*":

                            txtDisplay.Text = (Convert.ToDouble(results) * double.Parse(txtDisplay.Text)).ToString();

                            break;

                        case "/":

                            txtDisplay.Text = (Convert.ToDouble(results) / double.Parse(txtDisplay.Text)).ToString();

                            break;

                        

                    }

                }

                else

                {

                    int ischisl = Convert.ToInt32(vibor);

                    string res = results;

                    res = Convert.ToString(Convert.ToInt64(res, ischisl), 10);

                    string vxodi = txtDisplay.Text;

                    vxodi = Convert.ToString(Convert.ToInt64(txtDisplay.Text, ischisl), 10);

                    double a = Convert.ToDouble(res);

                    double b = Convert.ToDouble(vxodi);

                    string vivodi = "0";

                    switch (operation)

                    {

                        case "+":

                            vivodi = (a + b).ToString();

                            break;

                        case "-":

                            vivodi = (a - b).ToString();

                            break;

                        case "*":

                            vivodi = (a * b).ToString();

                            break;

                        case "/":

                            vivodi = (a / b).ToString();

                            break;

                        

                    }

                    string a2 = Convert.ToString(Convert.ToInt32(vivodi, 10), ischisl);

                    txtDisplay.Text = a2;

                    lblShowUp.Text = "";

                }

            }

            catch

            {

                txtDisplay.Text = "0";

                lblShowUp.Text = "";

            }

        }

        private void Button_Click_18(object sender, RoutedEventArgs e)

        {

            podschet();

        }



        private void Button_Click_39(object sender, RoutedEventArgs e)

        {

            double a = Convert.ToDouble(txtDisplay.Text) * -1;

            txtDisplay.Text = Convert.ToString(a);

        }

       

        private void Button_Click_20(object sender, RoutedEventArgs e)

        {

            vibor = 2;

        }

        private void Button_Click_21(object sender, RoutedEventArgs e)

        {

            vibor = 8;

        }

        private void Button_Click_22(object sender, RoutedEventArgs e)

        {

            vibor = 10;

        }

        private void Button_Click_23(object sender, RoutedEventArgs e)

        {

            vibor = 16;

        }

        private void Button_Click_44(object sender, RoutedEventArgs e)

        {

            chifra(sender);

        }

        private void Button_Click_45(object sender, RoutedEventArgs e)

        {

            chifra(sender);

        }

        private void Button_Click_46(object sender, RoutedEventArgs e)

        {

            chifra(sender);

        }

        private void Button_Click_47(object sender, RoutedEventArgs e)

        {

            chifra(sender);

        }

        private void Button_Click_48(object sender, RoutedEventArgs e)

        {

            chifra(sender);

        }

        private void Button_Click_49(object sender, RoutedEventArgs e)

        {

            chifra(sender);

        }
        private void Inzener_Click(object sender, RoutedEventArgs e)
        {
            Window1 window1 = new Window1();
            window1.Show();
            this.Hide();
        }

        private void Obichniy_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Hide();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(1);
        }

    }
}
