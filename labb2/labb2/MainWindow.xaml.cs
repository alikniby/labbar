using labb2;
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

namespace labb2
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

        private void btn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("hej");
        }
    }

    class House
    {

        class Members : House
        {

        }

        class Ravenclaw : House
        {

        }
        class Password : Ravenclaw
        {
            string password = "test";
        }
        class Mascot : Ravenclaw
        {
            string mascot = "test";
        }
        class HouseGhost : Ravenclaw
        {
            string houseGhost = "test";

        }
        Ravenclaw ravenclaw = new Ravenclaw();

    }


    class Griffydor : House
{

}
class Password : Griffydor
{
    string password = "test";
}
class Mascot : Griffydor
{
    string mascot = "test";
}
class HouseGhost : Griffydor
{
    string houseGhost = "test";
}

   


}













