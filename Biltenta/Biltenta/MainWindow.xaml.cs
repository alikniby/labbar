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

namespace Biltenta
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        String letters;
        public MainWindow()
        {
            InitializeComponent();
        }

        private  void Button_Click(object sender, RoutedEventArgs e)
        {
           letters = GetRandomLetters();
            Random rand = new Random(); 
            string numbers = rand.Next(1,99).ToString("D3");
            lblres.Content = numbers;

        }
        private static string GetRandomLetters()
        {
            Random r = new Random();
            string okLetters = "ABCDEFGHJKLMNPRSTUWXYX";
            string letters = "";
            for (int i = 0; i < 3; i++)
            {
                int index = r.Next(okLetters.Length);
                letters += okLetters[index].ToString();
            }
            return letters;
        }
        }
}
