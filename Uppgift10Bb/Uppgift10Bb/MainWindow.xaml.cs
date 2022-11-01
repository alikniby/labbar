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

namespace Uppgift10Bb
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

        private void BtnCheck_Click(object sender, RoutedEventArgs e)
        {

            int age;
            string name;
            Convert.ToString(TxtName.Text);
            name = TxtName.Text;
            Convert.ToInt32(TxtAge.Text);
            age = Convert.ToInt32(TxtAge.Text);
            if (RdNoadult.IsChecked == true)
                if (age < 15)
                {
                    TxtRes.Text = "Hej " + name + " Du är " + age + " du får kolla på filmer med åldersgränsen 11 år ";
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



            if (RdAdult.IsChecked == true)
            {
                if (age < 15)
                {
                    TxtRes.Text = "Hej " + name + " Du är " + age +
                        " år gammal. Då får du se filmer med åldersgräns upp till 11 år. Det spelar ingen roll att du går tillsammans med en vuxen.";
                    if (age <= 8)
                    {
                        TxtRes.Text = "Hej " + name + " Du är " + age +
                            " och får se filmer med åldersgräns upp till 11 år eftersom du har en vuxen med dig”";
                    }
                }
                if (age >= 15)
                {
                    TxtRes.Text = "Hej " + name + " Du är " + age +
                        " år gammal. Då kan du kolla på vilken film du vill.";

                }


            }

        }
    }
}
