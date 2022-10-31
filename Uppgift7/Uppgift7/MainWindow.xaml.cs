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

namespace Uppgift7
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
        private void Btntext_Click(object sender, RoutedEventArgs e)
        {

            string vis = "dölj lösenord";
            if (LblPassword.IsVisible)
            {
                LblPassword.Visibility = Visibility.Hidden;
                Btnhidden.Visibility = Visibility.Hidden;
            }
            else
            {
                Btnhidden.Visibility = Visibility.Visible;
                LblPassword.Visibility = Visibility.Visible;
                Btntext.Visibility = Visibility.Hidden;
            }


        }

        private void Btnhidden_Click(object sender, RoutedEventArgs e)
        {
           
                LblPassword.Visibility = Visibility.Hidden;
                Btnhidden.Visibility = Visibility.Hidden;
                Btntext.Visibility = Visibility.Visible;
            }

        }
    }

