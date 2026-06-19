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

namespace ex008
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int inicio = 0;
            int final = 0;

            int.TryParse(txtInicio.Text, out inicio);
            int.TryParse(txtFinal.Text, out final);

            Random gerador = new Random();

            int aleatorio = gerador.Next(inicio, final);

            txtResult.Content = aleatorio.ToString();
            txtResult.Visibility = Visibility.Visible;
        }
    }
}
