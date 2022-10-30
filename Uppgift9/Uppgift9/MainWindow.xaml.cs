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

namespace Uppgift9
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

        private void Btnconv_Click(object sender, RoutedEventArgs e)
        {
            decimal a, b, c;
            a = Convert.ToInt32(BtnG.Text);
            b = Convert.ToInt32(BtnS.Text);
            c = Convert.ToInt32(BtnK.Text);
            decimal d = Convert.ToDecimal("62,02");
            decimal sekel = Convert.ToDecimal("62,02");
            decimal knut = Convert.ToDecimal("62,02");
            d = a * d;
            sekel = b *(sekel/ 17);
            knut = c*( knut / 493);
            Math.Ceiling(d);
            Math.Ceiling(sekel);
            Math.Ceiling(knut);
            d = Convert.ToInt32(d);
            sekel = Convert.ToInt32(sekel);
            knut = Convert.ToInt32(knut);
            btnres.Text = knut + sekel+ d+ " SEK";
            
            









        }

    }
}
