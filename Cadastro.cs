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
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }
        private void LimparCampos()// limpa os dados na tela, para poder prencher o proximo
        {
            txbNome.Clear();
            txbEmail.Clear();
            txbTelefone.Clear();
            txbUsuario.Clear();
            txbSenha.Clear();
            txbNome.Focus();//volta o foco para a primeira posição
        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos(); //chama o metodo de limpar (reaproveitamento de codigo)
        }

        private void btnSalvar_Click(object sender, EventArgs e)// 
        {
            try
            {
                Usuario usuario = new Usuario(txbNome.Text, txbEmail.Text,
                    txbTelefone.Text, txbUsuario.Text, txbSenha.Text);//chamando o construtor para um usuario qualquer
                UsuarioDAO usuarioInserir = new UsuarioDAO(); //inserção do banco
                usuarioInserir.Inserir(usuario);//
                MessageBox.Show("Usuário " + usuario.Nome + " inserido com sucesso!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);//mostra que a operação foi realizada com sucesso
                LimparCampos();               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Cadastro_Load(object sender, EventArgs e)
        {
            

        }               

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }              

        private void Name_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
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

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void txbEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbTelefone_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
