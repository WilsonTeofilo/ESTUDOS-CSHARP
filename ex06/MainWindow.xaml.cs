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

namespace ex06
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
            int anonascimento = 0;
            int ano = DateTime.Now.Year;

      
            int.TryParse(EntradaAno.Text, out anonascimento);

            txtNascimento.Text = anonascimento.ToString();
            txtAtual.Text = ano.ToString();

            int idade = ano - anonascimento;
            txtAge.Text = idade.ToString();

            txtAtual.Visibility = Visibility.Visible;
            txtAge.Visibility = Visibility.Visible;
            txtNascimento.Visibility = Visibility.Visible;

            

        }
    }
}
