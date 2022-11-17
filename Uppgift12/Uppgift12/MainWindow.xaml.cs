using Microsoft.Win32.SafeHandles;
using System;
using System.Collections;
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
using System.Xml;

namespace Uppgift12
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int rndNr;
        int antalKast;
        int counter = 0;
        int countertwo = 0;
        int Antalfrsk = 1;





        public MainWindow()
        {
            InitializeComponent();

            
            
            Prgbar.Maximum = 100;
            Prgbar.Minimum = 0;
            double start = Prgbar.Value = 50;
            lblvalue.Content = start + " %";
        }

        private void Prgbar_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {



        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            Btncalc.IsEnabled = false;
            
           
            antalKast = Convert.ToInt32(txtbox.Text);
            //if (antalKast > int.Parse(txtbox.Text))
            //{

            //}



            //{
            for (int i = 0; i < antalKast; i++)
            {
                Random rnd = new Random();
                rndNr = rnd.Next(0, 10);
                if (rndNr <= 5)
                {

                    double plus = Prgbar.Value = 75 ;
                    lblvalue.Content = plus + " %";

                    countertwo++;

                    lblluck.Content = Convert.ToString("Antal rätt håll" + countertwo);
                    lblunluck.Content = Convert.ToString("Antal  fel håll " + counter);
                }
                else if (rndNr >= 5)
                {
                  double minus =  Prgbar.Value = 25;
                   lblvalue.Content = minus + " %";
                    counter++;

                    lblluck.Content = Convert.ToString("Antal rätt håll" + counter);
                    lblunluck.Content = Convert.ToString("Antal  fel håll " + countertwo);
                }
                else
                {
                    return;
                }   
                
            }

            Antalfrsk++;
        }


   
        private void btnLuck_Click(object sender, RoutedEventArgs e)
        {
            


            if (countertwo < 0 || counter > antalKast)
            {
                return;
            }
            else
            {
                lblunluck.Content = Convert.ToString("Antal  fel håll " + counter++);
                lblluck.Content = Convert.ToString("antal rätt håll" + countertwo--);


            }
            Prgbar.Value += 5;
            lblvalue.Content = " %";
        }
         
      
        private void btnUnluck_Click(object sender, RoutedEventArgs e)
        {
                if (counter < 0 || countertwo > antalKast)
                {
                    return;
                }
                else
                {
                    lblunluck.Content = Convert.ToString("antal fel håll" + countertwo++);
                    lblluck.Content = Convert.ToString("Antal  rätt håll " + counter--);
                        Prgbar.Value -= 5;
                    lblvalue.Content = " %";
                    
                }
            
               

                




        }

        private void txtbox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}





















