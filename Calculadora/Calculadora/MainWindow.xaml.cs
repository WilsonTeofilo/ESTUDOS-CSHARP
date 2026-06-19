using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Calculadora
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
        double val1;
        double val2;


        private void B1_Click(object sender, RoutedEventArgs e)
        {
            Result.Content += B1.Content.ToString();
        }

        private void B2_Click(object sender, RoutedEventArgs e)
        {
            Result.Content += B2.Content.ToString();
        }

        private void B3_Click(object sender, RoutedEventArgs e)
        {
            Result.Content += B3.Content.ToString();
        }

        private void B4_Click(object sender, RoutedEventArgs e)
        {
            Result.Content += B4.Content.ToString();
        }

        private void B5_Click(object sender, RoutedEventArgs e)
        {
            Result.Content += B5.Content.ToString();
        }

        private void B6_Click(object sender, RoutedEventArgs e)
        {
            Result.Content += B6.Content.ToString();
        }

        private void B7_Click(object sender, RoutedEventArgs e)
        {
            Result.Content += B7.Content.ToString();
        }

        private void B8_Click(object sender, RoutedEventArgs e)
        {
            Result.Content += B8.Content.ToString();
        }

        private void B9_Click(object sender, RoutedEventArgs e)
        {
            Result.Content += B9.Content.ToString();
        }

        private void B0_Click(object sender, RoutedEventArgs e)
        {
            Result.Content += B0.ToString();
        }

        private void B_C_Click(object sender, RoutedEventArgs e)
        {

        }

        

    }
}