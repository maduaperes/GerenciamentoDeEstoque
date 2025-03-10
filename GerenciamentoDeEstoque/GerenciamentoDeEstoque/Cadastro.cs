using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciamentoDeEstoque
{
    public partial class Cadastro: Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            // Verificar os campos para saber se forem prenchidos corretamente e caso esteja certo adicionar ao banco de dados

            Login formLogin = new Login();
            this.Close();
            formLogin.Show();
        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {
            Login formLogin = new Login();
            this.Close();
            formLogin.Show();
        }
    }
}
