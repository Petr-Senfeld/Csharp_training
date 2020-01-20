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

namespace Kalkulačka
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
        public string numberOne;
        public string numberTwo;
        string plusOperator = "";
        string minusOperator = "";
        string multiplyOperator = "";
        string divideOperator = "";
        string history;
        int total;

        bool a = true;
        bool b = false;
        bool c = false;
        public void Button_Click(object sender, RoutedEventArgs e)
        {
            Display.Text += "1";
            if (a)
            {
                numberOne += "1";
                history += numberOne;
            }
            else if (b)
            {
                numberTwo += "1";
                history += numberTwo;
            }
        }

        public void ButtonTwo_Click(object sender, RoutedEventArgs e)
        {
            Display.Text += "2";

        }

        public void ButtonThree_Click(object sender, RoutedEventArgs e)
        {
            Display.Text += "3";
            if (a)
            {
                numberOne += "3";
                history += numberOne;
            }
            else if (b)
            {
                numberTwo += "3";
                history += numberTwo;
            }
        }

        public void ButtonFour_Click(object sender, RoutedEventArgs e)
        {
            Display.Text += "4";
            if (a)
            {
                numberOne += "4";
                history += numberOne;
            }
            else if (b)
            {
                numberTwo += "4";
                history += numberTwo;
            }
        }

        public void ButtonFive_Click(object sender, RoutedEventArgs e)
        {
            Display.Text += "5";
            if (a)
            {
                numberOne += "5";
                history += numberOne;
            }
            else if (b)
            {
                numberTwo += "5";
                history += numberTwo;
            }
        }

        public void ButtonSix_Click(object sender, RoutedEventArgs e)
        {
            Display.Text += "6";
            if (a)
            {
                numberOne += "6";
                history += numberOne;
            }
            else if (b)
            {
                numberTwo += "6";
                history += numberTwo;
            }
        }

        public void ButtonSeven_Click(object sender, RoutedEventArgs e)
        {
            Display.Text += "7";
            if (a)
            {
                numberOne += "7";
                history += numberOne;
            }
            else if (b)
            {
                numberTwo += "7";
                history += numberTwo;
            }
        }

        public void ButtonEight_Click(object sender, RoutedEventArgs e)
        {
            Display.Text += "8";
            if (a)
            {
                numberOne += "8";
                history += numberOne;
            }
            else if (b)
            {
                numberTwo += "8";
                history += numberTwo;
            }
        }

        public void ButtonNine_Click(object sender, RoutedEventArgs e)
        {
            Display.Text += "9";
            if (a)
            {
                numberOne += "9";
                history += numberOne;
            }
            else if (b)
            {
                numberTwo += "9";
                history += numberTwo;
            }
        }

        public void ButtonZero_Click(object sender, RoutedEventArgs e)
        {
            Display.Text += "0";
            if (a)
            {
                numberOne += "0";
                history += numberOne;
            }
            else if (b)
            {
                numberTwo += "0";
                history += numberTwo;
            }
        }

        public void ButtonC_Click(object sender, RoutedEventArgs e)
        {
            Display.Text = "";
            numberOne = "";
            numberTwo = "";
            total = 0;
            plusOperator = "";
            minusOperator = "";
            history = "";

            a = true;
            b = false;
            c = false;

        }

        public void ButtonDel_Click(object sender, RoutedEventArgs e)
        {
            Display.Text = Display.Text.Remove(Display.Text.Length - 1);
        }

        public void ButtonPlusMinus_Click(object sender, RoutedEventArgs e)
        {
           
        }

        public void ButtonPlus_Click(object sender, RoutedEventArgs e)
        {
            if (a)
            {
                plusOperator += "+";
                Display.Text += "+";
                history += "+";
                c = true;
                a = false;
            }
            if (b)
            {
                plusOperator += "+";
                Display.Text += "+";
                history += "+";
                a = true;
                c = false;
                b = false;
            }
            if (c)
            {
                b = true;
            }

            if (plusOperator.Count() == 2)
            {
                total = Int32.Parse(numberOne) + Int32.Parse(numberTwo);
                Display.Text = total.ToString() + " + ";
                numberOne = "";
                numberTwo = "";

            }
            if (plusOperator.Count() > 2)
            {
                if (numberOne.Length >= 1)
                {
                    total += Convert.ToInt32(numberOne);
                    Display.Text = total.ToString() + " + ";
                    numberOne = "";
                }
                if (numberTwo.Length >= 1)
                {
                    total += Convert.ToInt32(numberTwo);
                    Display.Text = total.ToString() + " + ";
                    numberTwo = "";
                }
            }
        }
        public void ButtonEquals_Click(object sender, RoutedEventArgs e)
        {
            if(plusOperator.Length > 0)
            {
                if (plusOperator.Length == 1)
                {
                    total = Int32.Parse(numberOne) + Int32.Parse(numberTwo);
                    Display.Text += " = " + total;
                    history = Display.Text;
                    History.Text += history + "\n";
                    history = total.ToString();
                }
                if (plusOperator.Length > 1)
                {
                    if (numberOne.Length >= 1)
                    {
                        total += Convert.ToInt32(numberOne);
                        Display.Text = total.ToString();
                        history += " = " + total;
                        History.Text += history + "\n";
                        numberOne = "";
                        history = total.ToString();
                    }
                    if (numberTwo.Length >= 1)
                    {
                        total += Convert.ToInt32(numberTwo);
                        Display.Text = total.ToString();
                        history += " = " + total;
                        History.Text += history + "\n";
                        history = total.ToString();
                        numberTwo = "";
                    }
                }
            }
            if(minusOperator.Length > 0)
            {
                if (minusOperator.Length == 1)
                {
                    total = Int32.Parse(numberOne) - Int32.Parse(numberTwo);
                    Display.Text += " = " + total;
                    history = Display.Text;
                    History.Text += history + "\n";
                    history = total.ToString();
                }
                if (minusOperator.Length > 1)
                {
                    if (numberOne.Length >= 1)
                    {
                        total -= Convert.ToInt32(numberOne);
                        Display.Text = total.ToString();
                        history += " = " + total;
                        History.Text += history + "\n";
                        numberOne = "";
                        history = total.ToString();
                    }
                    if (numberTwo.Length >= 1)
                    {
                        total -= Convert.ToInt32(numberTwo);
                        Display.Text = total.ToString();
                        history += " = " + total;
                        History.Text += history + "\n";
                        history = total.ToString();
                        numberTwo = "";
                    }
                }
            }
        }

        public void ButtonMinus_Click(object sender, RoutedEventArgs e)
        {
            if (a)
            {
                minusOperator += "-";
                Display.Text += "-";
                history += "-";
                c = true;
                a = false;
            }
            if (b)
            {
                minusOperator += "-";
                Display.Text += "-";
                history += "-";
                a = true;
                c = false;
                b = false;
            }
            if (c)
            {
                b = true;
            }

            if (minusOperator.Count() == 2)
            {
                total = Int32.Parse(numberOne) - Int32.Parse(numberTwo);
                Display.Text = total.ToString() + " - ";
                numberOne = "";
                numberTwo = "";

            }
            if (minusOperator.Count() > 2)
            {
                if (numberOne.Length >= 1)
                {
                    total -= Convert.ToInt32(numberOne);
                    Display.Text = total.ToString() + " - ";
                    numberOne = "";
                }
                if (numberTwo.Length >= 1)
                {
                    total -= Convert.ToInt32(numberTwo);
                    Display.Text = total.ToString() + " - ";
                    numberTwo = "";
                }
            }
        }

        public void ButtonMultiply_Click(object sender, RoutedEventArgs e)
        {

        }

        public void ButtonDivide_Click(object sender, RoutedEventArgs e)
        {

        }

        public void ButtonPercenage_Click(object sender, RoutedEventArgs e)
        {

        }

        public void ButtonDecimal_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
