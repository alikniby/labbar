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

        string[] frukt = { "äpple", "päron", "banan", "ananas" };

        List<string> dyfrukter = new List<string>();
        int primeNr = 0;
        int prime = 2;

        bool isMoreFruit = true;

        Random rand = new Random();


        public MainWindow()
        {
            InitializeComponent();

        }

        private void fruktett_Click(object sender, RoutedEventArgs e)
        {
            primeNr = frukt.Length / prime;
            if (isMoreFruit == true)
            {
                primeNr = frukt.Length / prime;
                MessageBox.Show("tredje frukten i salladen är " + frukt[0] + " och " + frukt[3]);
            }
            else
            {
                MessageBox.Show("tredje frukten i salladen är " + frukt[0]);

            }







            {
            }
        }

        private void frukttwo_Click(object sender, RoutedEventArgs e)
        {
            primeNr = frukt.Length / prime;
            if (isMoreFruit == true)
            {
                primeNr = frukt.Length / prime;
                MessageBox.Show("tredje frukten i salladen är " + frukt[1] + " och " + frukt[3]);
            }
            else
            {
                MessageBox.Show("tredje frukten i salladen är " + frukt[1]);

            }
        }

        private void frukttre_Click(object sender, RoutedEventArgs e)
        {
            primeNr = frukt.Length / prime;
            if (isMoreFruit == true)
            {
                primeNr = frukt.Length / prime;
                MessageBox.Show("tredje frukten i salladen är " + frukt[2] + " och " + frukt[3]);
            }
            else
            {
                MessageBox.Show("tredje frukten i salladen är " + frukt[2]);

            }
        }
    }
}