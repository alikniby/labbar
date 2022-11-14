using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
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
using System.Xml.Xsl;
using static System.Net.Mime.MediaTypeNames;

namespace Uppgift17
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string counting = "";

        public MainWindow()
        {
            InitializeComponent();
            string test = txtBox.Text;

        }

        public char Jibberish()
        {
            char[] rep = { 'ö' };

            return rep[0];
        }

        public string IsVowel()
        {
            char[] vok = { 'a', 'e', 'i', 'o', 'u', 'y', 'å', 'ä', 'ö', };
            char[] rep = { 'ö' };
            String value = txtBox.Text;
            for (int i = 0; i < vok.Length; i++)
            {  
                
                if (value.Contains(vok[i]))
                {
                    value = value.Replace(vok[i], Jibberish());
                  
                }
              
            }
            NumberOfVowels(value);
            return value;

        }
        public int NumberOfVowels(String test)
        {
            char[] vok = { 'a', 'e', 'i', 'o', 'u', 'y', 'å', 'ä', 'ö',' ' };
            int count = 0;
            char[] rep = { 'ö' };
           

            foreach (char item in vok)
            {
                if (item  == vok[9] )
                {
                    //MessageBox.Show("fel tecken");
                }
                else
                {
                    count++;
                }
              
            }

           

            return count;


            }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
         
                lblres.Content = IsVowel();
                lblcount.Content = "Det fanns " + NumberOfVowels(counting) + " vokaler";

          
        }
    }

}
    


       
    






