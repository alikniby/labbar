using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.DirectoryServices;
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
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace Uppgift14
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double add;
        double sum;
        double parse;
        int counter = 0;

        
        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;

        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void btnNumber_TextChanged(object sender, TextChangedEventArgs e)
        {


        }
        int[] values = new int[5];

         
        private void btncalc_Click(object sender, RoutedEventArgs e)
        {
           
           int value = int.Parse(txtNumber.Text);
            values[counter] = value;

            if (counter == 4)
            {
                add = values[0] + values[1] + values[2] + values[3] + values[4];
                parse = add / values.Length;

                sum = parse;

                txttNumCalc.Text = sum.ToString();
                btncalc.Visibility = Visibility.Hidden;
            }
           
                listNum.ItemsSource = null;
                listNum.ItemsSource = values;
            
            
            counter++;


           
           

            /* bool countMax = counter == 4;
            //string text = txtNumber.Text; 
            int value = int.Parse(txtNumber.Text);
            values[counter] = value;   
            if (countMax)
            {
                 Sum();
                txttNumCalc.Text = sum.ToString();
            }
            else 
            {
                //   int allValues = 0;
            for (int i = 0; i < values.Length; i++)
            {

                 //   allValues += value;

            } 
                counter++;
            }


            listNum.ItemsSource = null;
            listNum.ItemsSource = values;

        }*/




            /*          private double Sum()
             {
              add = values[0] + values[1] + values[2] + values[3] + values[4];
              parse = add / values.Length;

                  sum = parse;

                  return sum;
             }



              private void txttNumCalc_TextChanged(object sender, TextChangedEventArgs e)
              {

              }
          }

           */

            
        }
        private void reset ()
        {
            txtNumber.Text = ("");
            txttNumCalc.Text = ("");
            Array.Clear(values,0, values.Length);
            listNum.ItemsSource = null;
            counter = 0;    
        }
        private void txttNumCalc_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void btnres_Click(object sender, RoutedEventArgs e)
        {
            reset();
        }
    }







}





