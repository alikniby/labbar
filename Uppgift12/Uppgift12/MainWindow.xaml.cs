using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Metrics;
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

namespace Uppgift12
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int procent = 0;
        int testar;
        int counter = 0;
        int countertwo = 0;
        int testar2 =1;


        public MainWindow()
        {
            InitializeComponent();
            double start = Prgbar.Value = 50;
            lblvalue.Content = start + " %";


        }

        private void Prgbar_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {



        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double value = Prgbar.Value = 100;
            lblvalue.Content = value + " %";
            Random rnd = new Random();
            procent = rnd.Next(1, 3);
            lblotur.Content = Convert.ToString(procent) + "Mindre otur";
            testar = Convert.ToInt32(txtbox.Text);

            double start = Prgbar.Value = 50;
            double going = Prgbar.Value = 25;
            double full = Prgbar.Maximum = 100;
            double minus = Prgbar.Minimum = 0;
            do
            {
            
                if (procent == 2 && procent != 3)
                {

                    Prgbar.Value = start + start;
                    lblvalue.Content = start + start + " %";
                    countertwo++;
                    count.Content = Convert.ToString("Antal mer otur" + testar2);
                }
                else if (procent == 1 && procent != 3)
                {
                    Prgbar.Value = minus;
                    lblvalue.Content = minus + " %";
                    counter++;
                    counttwo.Content = Convert.ToString("Antal mindre otur är resten" + testar2);
                }
                else
                {
                    return;
                }


                testar2++;
            } while (testar2 <= testar);
            counttwo.Content = Convert.ToString("Antal mindre otur är resten" + counter);
            count.Content = Convert.ToString("Antal mer otur" + countertwo);

        



            /*   for (int i = 0; i < testar; i++)

               {

                   procent = rnd.Next(1, 3);
                   if (procent == 2 && procent!=3)
                   {

                       Prgbar.Value = start + start;
                       lblvalue.Content = start + start + " %";
                       count.Content = Convert.ToString("Antal mer otur" +);
                   }
                   else if (procent == 1 && procent != 3)
                   {
                       Prgbar.Value = minus;
                       lblvalue.Content = minus + " %";
                       counttwo.Content = Convert.ToString("Antal mindre otur är resten" + i++);
                   }
                   else
                   {
                       return;
                   }


               }
           }*/


        }

        private void txtbox_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void btnreset_Click(object sender, RoutedEventArgs e)
        {



        }
    }
    


}








