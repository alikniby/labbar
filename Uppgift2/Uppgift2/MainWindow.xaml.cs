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
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace Uppgift2
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
        private void Txtbox_TextChanged(object sender, TextChangedEventArgs e)
        {
     
        }
        private void BtnName_Click(object sender, RoutedEventArgs e)
            
        {
            string txtName = Txtbox.Text;
            MessageBox.Show("Hej" + " "+ txtName + " "+ "Hoppas du mår bra");
        }

       
    }
}
