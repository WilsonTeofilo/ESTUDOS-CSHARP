using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercicios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private async void btnClicka_Click(object sender, EventArgs e)
        {
            await Task.Delay(1000);
        
            txtMeu.Visible = true;
            txtMeu.Text = "Meu"; 
            txtMeu.ForeColor = Color.White;
            txtMeu.BackColor = Color.Blue;

            await Task.Delay(1000);
            txtBrasil.Visible=true;
            txtBrasil.Text = "Brasil";
            txtBrasil.ForeColor = Color.Green;
            txtBrasil.BackColor = Color.Yellow;

            await Task.Delay(1000);
            txtBrasileiro.Text = "Brasileiro";
            txtBrasileiro.Visible = true;
            txtBrasileiro.ForeColor = Color.Yellow;
            txtBrasileiro.BackColor = Color.Green;





        }

        private void txtMeu_Click(object sender, EventArgs e)
        {

        }
    }
}
