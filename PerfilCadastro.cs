using chama.Modelo;
using chama.Utils;
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
    public partial class PerfilCadastro : Form
    {
        public PerfilCadastro()
        {

            InitializeComponent();
            
        }
        private void Menu_Load(object sender, EventArgs e)
        {
            /*try
            {
                Usuario usuario = new Usuario(txbNome.Text, txbEmail.Text,
                    txbTelefone.Text, txbUsuario.Text, txbSenha.Text);//chamando o construtor para um usuario qualquer
                UsuarioDAO usuarioAlterar = new UsuarioDAO(); //inserção do banco
                usuarioAlterar.Alterar(usuario);//
                MessageBox.Show("Usuário " + usuario.Nome + " inserido com sucesso!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);//mostra que a operação foi realizada com sucesso
                LimparCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }
    }
}
