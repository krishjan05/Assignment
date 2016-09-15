/* Assignment1Group1
 * Created by Krishna Kanhaiya
 * Created on 11 September 2016
 * This Program translates 3 Latin word viz. sinister, dexter and medium to english as Left, Right and Center respectively
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

namespace Assignment1Group1
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

        //Function to display the translation of sinister to English when sinister Button is clicked
        private void btnEnglishLeft_Click(object sender, RoutedEventArgs e)
        {
            lblLatinLeft.Visibility = Visibility.Visible;
            lblLatinCenter.Visibility = Visibility.Hidden;
            lblLatinRight.Visibility = Visibility.Hidden;
        }

        //Function to display the translation of dexter to English when dexter Button is clicked
        private void btnEnglishRight_Click(object sender, RoutedEventArgs e)
        {
            lblLatinLeft.Visibility = Visibility.Hidden;
            lblLatinCenter.Visibility = Visibility.Hidden;
            lblLatinRight.Visibility = Visibility.Visible;
        }

        //Function to display the translation of medium to English when medium Button is clicked
        private void btnEnglishCenter_Click(object sender, RoutedEventArgs e)
        {
            lblLatinLeft.Visibility = Visibility.Hidden;
            lblLatinCenter.Visibility = Visibility.Visible;
            lblLatinRight.Visibility = Visibility.Hidden;
        }
    }
}
