/* MainWindow.xaml.cs
 * Created by Krishna Kanhaiya
 * Created on 15 September 2016
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

namespace Assignment2Group1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        decimal ClassACost = 15;
        decimal ClassBCost = 12;
        decimal ClassCCost = 9;
        decimal GrandTotal = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            int ClassASeatCount, ClassBSeatCount ,ClassCSeatCount;
            decimal ClassATotal, ClassBTotal, ClassCTotal;
            try
            {
                if(int.TryParse(txtClassA.Text, out ClassASeatCount) &&
                    int.TryParse(txtClassB.Text, out ClassBSeatCount) &&
                    int.TryParse(txtClassC.Text, out ClassCSeatCount))
                {
                    ClassATotal = ClassASeatCount * ClassACost;
                    ClassBTotal = ClassBSeatCount * ClassBCost;
                    ClassCTotal = ClassCSeatCount * ClassCCost;
                    GrandTotal = ClassATotal + ClassBTotal + ClassCTotal;

                    lblClassATotal.Content = ClassATotal.ToString("n2");
                    lblClassBTotal.Content = ClassBTotal.ToString("n2");
                    lblClassCTotal.Content = ClassCTotal.ToString("n2");
                    lblGrandTotal.Content = "Grand Total = $" + GrandTotal.ToString("n2");
                    MessageBox.Show("Grand Total = " + GrandTotal.ToString("n2"), "Total Amount");
                }
                else
                {
                    MessageBox.Show("Please enter valid count of seat", "Error");
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + "Please enter valid number of seats");
            }

        }
    }
}
