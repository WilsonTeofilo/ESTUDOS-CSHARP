using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex004
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClique_Click(object sender, EventArgs e)
        {
            double num = 0;
            double.TryParse(txtNum.Text, out num);
            txtN1.Visible = true;
            txtN2.Visible = true;
            txtN3.Visible = true;
            txtN1.Text = $"SEU NUMERO COM 3 DECIMAIS: {num:N3}";
            txtN2.Text = $"a parte inteira do seu número é : {Math.Truncate(num)}";
            txtN3.Text = $"Seu numero arredondado: {Math.Round(num)}";



        }
    }
}
