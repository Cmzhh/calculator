using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string first_numnber, number2;
        public int way,num1=0,num2;
        public int result;
        public int re;

       
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void Click_result(object sender, RoutedEventArgs e)
        {
            num2 = Convert.ToInt32(textBlock1.Text);
            switch (way)
            {
                case 1:
                    result = num1 + num2;
                    re = result;
                    textBlock1.Text = re.ToString();
                    break;
                case 2:
                    result = num1 - num2;
                    re = result;
                    textBlock1.Text = re.ToString();
                    break;
                case 3:
                    result = num1 * num2;
                    re = result;
                    textBlock1.Text = re.ToString();
                    break;
                case 4:
                    result = num1 / num2;
                    re = result;
                    textBlock1.Text = re.ToString();
                    break;
            }

            result = 0;

        }

        private void Click_1(object sender, RoutedEventArgs e)
        {
            cut();
            int i = 1;
            textBlock1.Inlines.Add(i.ToString());
        }
        private void Click_2(object sender, RoutedEventArgs e)
        {
            cut();
            int i = 2;
            textBlock1.Inlines.Add(i.ToString());
        }
        private void Click_3(object sender, RoutedEventArgs e)
        {
            cut();
            int i = 3;
            textBlock1.Inlines.Add(i.ToString());
        }
        private void Click_4(object sender, RoutedEventArgs e)
        {
            cut();
            int i = 4;
            textBlock1.Inlines.Add(i.ToString());
        }
        private void Click_5(object sender, RoutedEventArgs e)
        {
            cut();
            int i = 5;
            textBlock1.Inlines.Add(i.ToString());
        }
        private void Click_6(object sender, RoutedEventArgs e)
        {
            cut();
            int i = 6;
            textBlock1.Inlines.Add(i.ToString());
        }
        private void Click_7(object sender, RoutedEventArgs e)
        {
            cut();
            int i = 7;
            textBlock1.Inlines.Add(i.ToString());
        }
        private void Click_8(object sender, RoutedEventArgs e)
        {
            cut();
            int i = 8;
            textBlock1.Inlines.Add(i.ToString());
        }
        private void Click_9(object sender, RoutedEventArgs e)
        {
            cut();
            int i = 9;
            textBlock1.Inlines.Add(i.ToString());
        }
        private void Click_add(object sender, RoutedEventArgs e)
        {
            
              num1=Convert.ToInt32(textBlock1.Text);
                textBlock1.Text = "";
                way = 1;
        }
        private void Click_substract(object sender, RoutedEventArgs e)
        {
           
                num1 = Convert.ToInt32(textBlock1.Text);
                textBlock1.Text = "";
                way = 2;
         
           

        }
        private void Click_mutiply(object sender, RoutedEventArgs e)
        {
           
                num1 = Convert.ToInt32(textBlock1.Text);
                textBlock1.Text = "";
                way = 3;
       
           

        }
        private void Click_divied(object sender, RoutedEventArgs e)
        {
            
                num1 = Convert.ToInt32(textBlock1.Text);
                textBlock1.Text = "";
                way = 4;
            
           

        }
        private void Click_remove(object sender, RoutedEventArgs e)
        {
            textBlock1.Text = "";
            first_numnber = "";
            number2 = "";
        }
        private void Click_dele(object sender, RoutedEventArgs e)
        {
            if (textBlock1.Text.Length>0)
            {
                textBlock1.Text = textBlock1.Text.Remove(textBlock1.Text.Length - 1);
            }
           
        }

        public void cut()
        {
            if (textBlock1.Text =="please input number")
            {
                textBlock1.Text = "";
            }
        }
     

    }

}
