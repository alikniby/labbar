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

namespace Uppgift13
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        string[] frukt = { "äpple", "päron", "banan" };


        int primeNr = 0;
        int prime = 2;

       

        Random rand = new Random();


        public MainWindow()
        {
            InitializeComponent();

        }

        private void fruktett_Click(object sender, RoutedEventArgs e)
        {
             primeNr = frukt.Length / prime; 
           
            for (int i = 0; i < frukt.Length; i++)
            { 
                
                MessageBox.Show("första frukten i salladen är " + frukt[i]);
               
                if (i == 0)
                {
                   
                   return;
                }

            }


            //{
            //}
        }

        private void frukttwo_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 2; i < frukt.Length; i++)
            {
                primeNr = frukt.Length % prime;
                if (primeNr != 0)
                {
                    primeNr = frukt.Length / prime;
                    MessageBox.Show("tredje frukten i salladen är " + frukt[i] + " och " + frukt[i-1]);
                    return;
                }
                else
                {
                    MessageBox.Show("tredje frukten i salladen är " + frukt[i]);

                }
            }


        }

        private void frukttre_Click(object sender, RoutedEventArgs e)
        {


            for (int i = frukt.Length-1; i < frukt.Length; i++)
            {

                MessageBox.Show("första frukten i salladen är " + frukt[i]);

                if (i == frukt.Length - 1)
                {

                    return;
                }

            }

        }
    }
}