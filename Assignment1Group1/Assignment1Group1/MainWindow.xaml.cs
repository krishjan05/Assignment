/*This Program displays english word for Latin word
*/
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

namespace Grp1_assign1
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

        //When this Button is clicked, it shows english word for Sinister
        private void btn_sinister_Click(object sender, RoutedEventArgs e)
        {
            lbl_center.Content = "Left";
        }

        //When this Button is clicked, it shows english word for Dexter
        private void btn_dexter_Click(object sender, RoutedEventArgs e)
        {
            lbl_center.Content = "Right";
        }

        //When this Button is clicked, it shows english word for Medium
        private void btn_medium_Click(object sender, RoutedEventArgs e)
        {
            lbl_center.Content = "Center";
        }
    }
}
