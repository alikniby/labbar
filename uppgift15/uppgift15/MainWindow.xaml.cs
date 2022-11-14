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

namespace uppgift15
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int count =0;
       
        

        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
           
        }

        private void btnCalc_Click(object sender, RoutedEventArgs e)
        {
            string text =  txtInsert.Text;
            char texttwo = char.Parse(txtChar.Text);
            count = 0;

            foreach (char item in text)
            {
                if (item == texttwo)
                {
                   count++;
                    lblRes.Content = "Du har skrivit ut " +" " + item + " " + count + "  gånger";
                }
                else
                {
                    count = 0;
                    lblRes.Content = "Du har skrivit ut " + " " + texttwo + " " + count + "  gånger";
                }
            
        
}          
           /* char test = char.Parse(txtChar.Text);
              if (test != texttwo)
                {
                   count--;
                lblRes.Content = "Du har skrivit ut " + " " + texttwo + " " + count + "  gånger";
            }*/
        }
        




}
    }

