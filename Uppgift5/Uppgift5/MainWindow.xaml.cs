using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
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

namespace Uppgift5
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

        private void btnkvot_Click(object sender, RoutedEventArgs e)
        {
           // Man kan även använda sig av float eller decimal skulle jag gissa för att få fram samma resultat.
            double a = Convert.ToInt32(Num1.Text);
            double b = Convert.ToInt32(Num2.Text);
            double sum = a/ b;
            btnsum.Text = sum.ToString();
            Math.Round(sum, 2);
            txtres.Text = "Kvot";

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void Btnrensa_Click(object sender, RoutedEventArgs e)
        {
            Num1.Clear();
            Num2.Clear();
            btnsum.Clear();
        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void btnmulti_Click(object sender, RoutedEventArgs e)
        {
            double a = Convert.ToInt32(Num1.Text);
            double b = Convert.ToInt32(Num2.Text);
            double sum = a * b;
            btnsum.Text = sum.ToString();
            Math.Round(sum, 2);
            txtres.Text = "Produkt";

        }

        private void btnadd_Click(object sender, RoutedEventArgs e)
        {
            double a = Convert.ToInt32(Num1.Text);
            double b = Convert.ToInt32(Num2.Text);
            double sum = a + b;
            btnsum.Text = sum.ToString();
            Math.Round(sum, 2);
            txtres.Text = "Summa";

        }

        private void btnsub_Click(object sender, RoutedEventArgs e)
        {
            double a = Convert.ToInt32(Num1.Text);
            double b = Convert.ToInt32(Num2.Text);
            double sum = a - b;
            btnsum.Text = sum.ToString();
            Math.Round(sum, 2);
            txtres.Text = "Differens";
        }

        private void btnres_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
