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

            double start = Prgbar.Value = 50;
            lblvalue.Content = start + " %";



        }

        private void Prgbar_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {



        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {


            antalKast = Convert.ToInt32(txtbox.Text);

            double start = Prgbar.Value = 50;
            double going = Prgbar.Value = 25;
            double full = Prgbar.Maximum = 100;
            double minus = Prgbar.Minimum = 0;



            //{
            for (int i = 0; i < antalKast; i++)
            {
                Random rnd = new Random();
                rndNr = rnd.Next(0, 10);
                if (rndNr <= 5)
                {

                    Prgbar.Value = start + going;
                    lblvalue.Content = start + going + " %";

                    countertwo++;

                    lblcount.Content = Convert.ToString("Antal rätt håll" + countertwo);
                    lblcount2.Content = Convert.ToString("Antal  fel håll " + counter);
                }
                else if (rndNr >= 6)
                {
                    Prgbar.Value = start - going;
                    lblvalue.Content = start - going + " %";
                    counter++;

                    lblcount.Content = Convert.ToString("Antal rätt håll" + counter);
                    lblcount2.Content = Convert.ToString("Antal  fel håll " + countertwo);
                }
                else
                {
                    return;
                }

            }


            Antalfrsk++;
            // } while (Antalfrsk <= antalKast);
            //lblcount2.Content = Convert.ToString("Antal mer otur " + countertwo);
            //     lblcount.Content = Convert.ToString("Antal mindre otur " + counter);






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




        private int plus = +5;
        private int minus = -5;

        private void btnLuck_Click(object sender, RoutedEventArgs e)
        {
            int[] kast = { 1, 3, 5, 8, 10 };


            Prgbar.Value += 5;
            for (int i = 0; i < kast.Length; i++)
            {
                plus = countertwo;
                minus = counter;




                int del = (int)Prgbar.Value;

                lblvalue.Content = del + " %";
                if (countertwo <= 0 || counter > antalKast)
                {
                    break;
                }
                else
                {
                    lblcount.Content = Convert.ToString("Antal  fel håll " + counter++);
                    lblcount2.Content = Convert.ToString("antal rätt håll" + countertwo--);

                }


              

            }
        }
        private int plus2 = +5;
        private int minus2 = -5;
        private void btnUnluck_Click(object sender, RoutedEventArgs e)
        {
            int[] kast = { 1, 3, 5, 8, 10 };


            Prgbar.Value -= 5;
            for (int i = 0; i < kast.Length; i++)
            {
                plus2 = countertwo;
                minus2 = counter;




                int del = (int)Prgbar.Value;

                lblvalue.Content = del + " %";


                if (counter <= 0 || countertwo > antalKast)
                {
                    break;
                }
                else
                {
                    lblcount.Content = Convert.ToString("Antal  rätt håll " + counter--);
                    lblcount2.Content = Convert.ToString("antal fel håll" + countertwo++);

                }

               




            }
        }

        private void txtbox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}




















