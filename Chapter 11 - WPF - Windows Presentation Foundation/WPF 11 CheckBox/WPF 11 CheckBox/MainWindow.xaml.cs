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

namespace WPF_11_CheckBox
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

        private void cbAllCheckedChanged(object sender, RoutedEventArgs e)
        {
            bool newVal = (cbAllTopings.IsChecked == true);
            cbSalame.IsChecked = newVal;
            cbMushroom.IsChecked = newVal;
            cbGorgonzola.IsChecked = newVal;
        }

        private void cbSingleCheckedChanged(object sender, RoutedEventArgs e)
        {
            cbAllTopings.IsChecked = null;
            if((cbSalame.IsChecked==true) && (cbMushroom.IsChecked==true) && (cbGorgonzola.IsChecked == true))
            {
                cbAllTopings.IsChecked = true;
            }
            if ((cbSalame.IsChecked == false) && (cbMushroom.IsChecked == false) && (cbGorgonzola.IsChecked == false))
            {
                cbAllTopings.IsChecked = false;
            }

        }
    }
}
