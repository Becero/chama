using chama.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace chama
{
    public partial class TelaPrincipal : Form
    {
       private int Id;
        public TelaPrincipal(int id)
        {

            InitializeComponent();
            Id = id;
        }

        private void perfilToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void TelaPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {                    
              this.Close();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            CadastroEmprego cadastro2 = new CadastroEmprego();
            cadastro2.ShowDialog();
            this.Visible = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {           
                this.Visible = false;
                Cadastro cadastro = new Cadastro(Id);
                cadastro.ShowDialog();
                this.Visible = true;
            
        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Cadastro cadastro = new Cadastro(Id);
            cadastro.ShowDialog();
            this.Visible = true;
        }

        private void alterarSenhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Id != -1)
            {
                UsuarioDAO identificar = new UsuarioDAO();
                Usuario user = identificar.Identificar(Id);
                /*txbNome.Text = user.Nome;
                txbEmail.Text = user.Email;
                txbTelefone.Text = user.Telefone;
                txbUsuario.Text = user.UsuarioSis;
                txbSenha.Visible = false;
                groupBox1.Visible = true;
                */
            }
        }
    }
}
