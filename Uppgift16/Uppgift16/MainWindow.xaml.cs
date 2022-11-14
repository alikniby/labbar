using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
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

namespace Uppgift16
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
            string value1 = txtCal.Text;
            
        }

        public static bool CheckChar(string value1)
        {
            int index = 0;
            //bool result = Regex.IsMatch(value1, "^[a-zA-Z]+$");
            foreach (char c in value1)
            {
                if (!char.IsLetter(c))
                {
             index =   DateTime.Now.Year - int.Parse(value1);
               MessageBox.Show("du är " + index + " år"); break;
                }
               
                else
                {
                    MessageBox.Show("Det innehåller text");
                    break;
                }
                }
return true;
            }





        


        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void btncalc_Click(object sender, RoutedEventArgs e)
        {
            CheckChar(txtCal.Text);
        }
    }

     

}
