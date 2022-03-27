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
using TestPP02;

namespace TestPP02
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        

        private void btnRasschet_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                txtSumm.Content = Class1.tarifMin(Radio1.IsChecked.Value, Convert.ToDouble(txtMinutes.Text)).Item3;
            }
            catch
            {
                MessageBox.Show("Ошибка");
            }
        }
    }
}
