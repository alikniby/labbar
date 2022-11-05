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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    public partial class MainWindow : Window
    {
   string regnr;
        bool reg;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
if (txtbox.Text.Length < 7)
            {
                MessageBox.Show("ff");
            }
            if (txtbox.Text.Length > 7)
            {
                MessageBox.Show("f2f");
            }
            else if (txtbox.Text.Length == 7)
            {
                MessageBox.Show("Volvoxc40");

            }




        }

        private void txtbox_TextChanged(object sender, TextChangedEventArgs e)
        {

            
        }
    }
}
