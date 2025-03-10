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
    public partial class Login: Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            // verificar se o usuário e senha estão corretos e caso esteja certo abrir o form Home

            HomeAdm formHome = new HomeAdm();
            formHome.Show();
            this.Hide();
        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {
            Cadastro formCadastro = new Cadastro();
            this.Hide();
            formCadastro.Show();
           
        }
    }
}
