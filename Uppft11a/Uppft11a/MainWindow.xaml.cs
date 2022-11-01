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


namespace Uppft11a
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random randomNr = new Random();
        
  

        public MainWindow(int rndValue)
        {
            InitializeComponent();
       
            int slumpliv = randomNr.Next(1, 1000);
            
            btntest.Text = Convert.ToString(slumpliv);
        }

        

        private void BtnRan_Click(object sender, RoutedEventArgs e)
        {
          


        }
     

        private void BtnGuess_Click(object sender, RoutedEventArgs e)
        {
            
            /* string randsum;
             int guess;
             int rando = Rand.Next(0, 100);

             guess = Convert.ToInt32(txtGuess.Text);
             randsum = Convert.ToString(rando);

             if (rando > guess)
             {
                 TxtRes.Text = Convert.ToString(rando + "Inte  nära kompis");
             }
             else
             {
                 TxtRes.Text = Convert.ToString(rando + "Det är nära de är bra ");
             }
             if (rando == guess)
             {
                 TxtRes.Text = Convert.ToString(rando + "HELT RÄTTT");
             }*/

            string randsum;
            bool guessnr = false;
            int slumpliv = randomNr.Next(1000);
            randsum = Convert.ToString(slumpliv);
            int guess = Convert.ToInt32(slumpliv);
            int guess2 = Convert.ToInt32(txtGuess.Text);
            var diffrence = guess2 - slumpliv;
            diffrence = Math.Abs(diffrence);

            if (diffrence >= 1 && diffrence <= 50)
            {
                lblres.Content = Convert.ToString(" För HÖGT nummer" + slumpliv);
            }
            else if (diffrence >= 51 && diffrence <= 99)
            {
                lblres.Content = Convert.ToString(" För HÖGT nummer" + slumpliv);
            }
            else if (diffrence >= 99 && diffrence <= 149)
            {
                lblres.Content = Convert.ToString(" För HÖGT nummer" + slumpliv);
            }
            else if (diffrence >= 150 && diffrence <= 201)
            {
                lblres.Content = Convert.ToString(" För HÖGT nummer" + slumpliv);
            }
            else if (diffrence == 0)
            {
                lblres.Content = Convert.ToString("HELT RÄTT " + slumpliv);
            }
            





            /*if (slumpliv > 1 && slumpliv <= 100)
            {
                TxtRes.Text = Convert.ToString("  Alldels för långt ifrån kompis" + slumpliv);

            }
            else
            {
                TxtRes.Text = Convert.ToString("  Närmare" + slumpliv);
            }*/



        }
    }
    }

