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

namespace chama
{
    
    public partial class TeladeLogin : Form
    {
        public TeladeLogin()
        {
            InitializeComponent();            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            UsuarioDAO usuarioLogin = new UsuarioDAO();
            try
            {
                int Id = usuarioLogin.Devolver(tbLogin.Text, txbSenha.Text);
                if (Id != -1) 
                {
                    MessageBox.Show("SUCESSO!", "Você foi Logado com sucesso", MessageBoxButtons.OK);
                    //Usuario login = usuarioLogin.Alterar(tbLogin.Text, txbSenha.Text);
                   

                        TelaPrincipal telaPrincipal = new TelaPrincipal(Id);
                        txbSenha.Clear();
                        telaPrincipal.ShowDialog(); 
                        this.Visible = true;

                }
                else
                {
                    throw new Exception("Verifique seu Login e Senha");
                }

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "AVISO", MessageBoxButtons.OK);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Cadastro cadastro = new Cadastro(-1);
            cadastro.ShowDialog();
            this.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
