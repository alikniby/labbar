using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
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


namespace Uppft11a
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        //deklererar två int

        int slumpTal =0;
        int guess;
        int counter = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        

        private void BtnRan_Click(object sender, RoutedEventArgs e)
        {
            //skapar slump nr med hjälp av klassen random
            BtnGuess.IsEnabled = true;
          
       

            Random randomNr = new Random();
            slumpTal = randomNr.Next(1, 1000);
            Listtest.Items.Add(Convert.ToString(slumpTal))  ;
            

        }

        private void BtnGuess_Click(object sender, RoutedEventArgs e)
        {    counter++;
            //Här indiekrar jag att textfältet inte ska krasha när den är  tom om den inte är tom ska den använda sig av string guess för att skriva in text i fältet
            if (string.IsNullOrEmpty(txtGuess.Text))
            {
                return;
            }
            else
            {
               guess = Convert.ToInt32(txtGuess.Text);


            }


            // för att få fram skillnaden mellan inmatade talet och slumptalet så tar jag båda minusvarandra och lagrar det i en variabel vid namnet diffrence, därefter anropas funktionen absolutbelopp för at få talet positiv hela tiden
                var diffrence = guess - slumpTal;
                diffrence = Math.Abs(diffrence);


            //If villkor som säger att ifall skillnaden mellan inmatade siffra  minus slumptal är större än hundra eller mindre än hundra
             if (guess > 1000)
            {
                lblres.Content = Convert.ToString(" talet måste vara mellan 1-1000");
            }
            else if (guess < slumpTal && diffrence >= 1 && diffrence <= 100)
             {
                 lblres.Content = Convert.ToString(" För LÅGT nummer");

             }
             else if (guess > slumpTal && diffrence >= 1 && diffrence <= 100)
             {
                 lblres.Content = Convert.ToString("  högt nummer");
             }
             else if (guess > slumpTal && diffrence >= 101)
             {
                 lblres.Content = Convert.ToString(" Alldels för långt ifrån lågt nummer");
             }
             else if (guess < slumpTal && diffrence >= 101)
             {
                 lblres.Content = Convert.ToString(" Alldels för långt ifrån högt");
             }
           
             
             else 
             {
                lblres.Content = Convert.ToString("HELT RÄTT du gissade rätt efter " + counter + " gånger") ;
                
             }

             
           

        }


    }
    }
       

