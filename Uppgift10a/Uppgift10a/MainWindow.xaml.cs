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
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Uppgift10a
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

        private void TxtName_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TxtAge_TextChanged(object sender, TextChangedEventArgs e)
        {


        }

        private void BtnCheck_Click(object sender, RoutedEventArgs e)

        {
            int age;
            string name;
            Convert.ToString(TxtName.Text);
            name = TxtName.Text;
            Convert.ToInt32(TxtAge.Text);
            age = Convert.ToInt32(TxtAge.Text);
            if (age < 15)
            {
                TxtRes.Text = "Hej " + name +" Du är " + age + " du får kolla på filmer med åldersgränsen 11 år ";
            }
            if (age == 15)
            {
                TxtRes.Text = "Hej " + name + " Du är " + age + " alla i sällskapet måste vara 15 år eller äldre ";
            }
            if (age > 15)
            {
                TxtRes.Text = "Hej " + name + " Du är " + age + " du får kolla på alla filmer";
            }
            if (age <= 8)
            {
                TxtRes.Text = "Hej " + name + " Du är " + age + " du får kolla på filmer med åldersgränsen 7 år ";
            }
            

        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)

        {
   
            int age;
            string name;
            Convert.ToString(TxtName.Text);
            name = TxtName.Text;
            Convert.ToInt32(TxtAge.Text);
            age = Convert.ToInt32(TxtAge.Text);
            if (age < 15)
            {
                BtnCheck_Click(sender, e);
                TxtRes.Text ="sjukatt" + age;
            }
        }
    }
}
