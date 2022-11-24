using chama.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chama
{
    public partial class Cadastro : Form
    {
        private int Id;
        public Cadastro(int id)
        {
            InitializeComponent();
            Id = id;
            
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
            if(Id != -1)
            {
                UsuarioDAO identificar = new UsuarioDAO();
                Usuario user = identificar.Identificar(Id);
                txbNome.Text = user.Nome;
                txbEmail.Text = user.Email;
                txbTelefone.Text = user.Telefone;
                txbUsuario.Text = user.UsuarioSis;
                lbSenha.Visible = false;
                txbSenha.Visible = false;
                Endereço.Visible = true;
                Sobre.Visible = true;
                
            }
        }       
        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       
        private void txbUsuario_Enter(object sender, EventArgs e)
        {
            if(txbUsuario.Text.Equals("Usuario"))
            {
                txbUsuario.Text = "\0";              
            }
            //else(txbUsuario)
           
        }

        private void txbSenha_Enter(object sender, EventArgs e)
        {
            if (txbSenha.Text.Equals("Senha"))
            {
                txbSenha.Text = "\0";
            }
        }

        private void txbNome_Enter(object sender, EventArgs e)
        {
            if (txbNome.Text.Equals("Nome Completo"))
            {
                txbNome.Text = "\0";
            }
        }
       
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void txbNome_Enter_1(object sender, EventArgs e)
        {
            if (txbSenha.Text.Equals("Senha"))
            {
                txbSenha.Text = "\0";
            }
        }

        private void txbSenha_Enter_1(object sender, EventArgs e)
        {
            if (txbSenha.Text.Equals("Senha"))
            {
                txbSenha.Text = "\0";
            }
        }

        private void txbUsuario_Enter_1(object sender, EventArgs e)
        {
            if (txbUsuario.Text.Equals("Usuario"))
            {
                txbUsuario.Text = "\0";
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Usuario_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
