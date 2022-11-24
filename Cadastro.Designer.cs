namespace chama
{
    partial class Cadastro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.botoes = new System.Windows.Forms.Panel();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Sobre = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.Endereço = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txbEstado = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txbCidade = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txbCEP = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txbBairro = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txbComplemento = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbNumero = new System.Windows.Forms.TextBox();
            this.txbRua = new System.Windows.Forms.TextBox();
            this.Usuario = new System.Windows.Forms.GroupBox();
            this.lbSenha = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Telefone = new System.Windows.Forms.Label();
            this.txbTelefone = new System.Windows.Forms.MaskedTextBox();
            this.txbSenha = new System.Windows.Forms.TextBox();
            this.txbUsuario = new System.Windows.Forms.TextBox();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.botoes.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.Sobre.SuspendLayout();
            this.Endereço.SuspendLayout();
            this.Usuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(31, 6);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(49, 23);
            this.btnVoltar.TabIndex = 18;
            this.btnVoltar.Text = "◀";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(110, 6);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(49, 23);
            this.button4.TabIndex = 19;
            this.button4.Text = "☐";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(184, 6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(49, 23);
            this.button3.TabIndex = 20;
            this.button3.Text = "●";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // botoes
            // 
            this.botoes.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.botoes.Controls.Add(this.button3);
            this.botoes.Controls.Add(this.button4);
            this.botoes.Controls.Add(this.btnVoltar);
            this.botoes.Location = new System.Drawing.Point(-10, 371);
            this.botoes.Name = "botoes";
            this.botoes.Size = new System.Drawing.Size(253, 40);
            this.botoes.TabIndex = 21;
            this.botoes.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(31, 11);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(82, 23);
            this.btnSalvar.TabIndex = 17;
            this.btnSalvar.Text = "SALVAR";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(140, 12);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(82, 23);
            this.btnLimpar.TabIndex = 6;
            this.btnLimpar.Text = "LIMPAR";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnLimpar);
            this.panel2.Controls.Add(this.btnSalvar);
            this.panel2.Location = new System.Drawing.Point(0, 328);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(243, 41);
            this.panel2.TabIndex = 22;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.Sobre);
            this.panel1.Controls.Add(this.Endereço);
            this.panel1.Controls.Add(this.Usuario);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(243, 320);
            this.panel1.TabIndex = 27;
            // 
            // Sobre
            // 
            this.Sobre.Controls.Add(this.label1);
            this.Sobre.Controls.Add(this.textBox1);
            this.Sobre.Controls.Add(this.label12);
            this.Sobre.Controls.Add(this.dateTimePicker1);
            this.Sobre.Controls.Add(this.label13);
            this.Sobre.Controls.Add(this.label11);
            this.Sobre.Controls.Add(this.textBox2);
            this.Sobre.Controls.Add(this.textBox4);
            this.Sobre.Location = new System.Drawing.Point(7, 220);
            this.Sobre.Name = "Sobre";
            this.Sobre.Size = new System.Drawing.Size(215, 204);
            this.Sobre.TabIndex = 25;
            this.Sobre.TabStop = false;
            this.Sobre.Text = "Sobre";
            this.Sobre.Visible = false;
            this.Sobre.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 61);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(107, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "Data de Nascimento:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(8, 77);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(108, 20);
            this.dateTimePicker1.TabIndex = 22;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(8, 22);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 13);
            this.label13.TabIndex = 21;
            this.label13.Text = "Escolaridade";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 100);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "Ramo de Atuação";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(8, 116);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(106, 20);
            this.textBox2.TabIndex = 9;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(8, 38);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(141, 20);
            this.textBox4.TabIndex = 2;
            // 
            // Endereço
            // 
            this.Endereço.Controls.Add(this.label9);
            this.Endereço.Controls.Add(this.txbEstado);
            this.Endereço.Controls.Add(this.label8);
            this.Endereço.Controls.Add(this.txbCidade);
            this.Endereço.Controls.Add(this.label7);
            this.Endereço.Controls.Add(this.txbCEP);
            this.Endereço.Controls.Add(this.label6);
            this.Endereço.Controls.Add(this.txbBairro);
            this.Endereço.Controls.Add(this.label5);
            this.Endereço.Controls.Add(this.txbComplemento);
            this.Endereço.Controls.Add(this.label4);
            this.Endereço.Controls.Add(this.label3);
            this.Endereço.Controls.Add(this.txbNumero);
            this.Endereço.Controls.Add(this.txbRua);
            this.Endereço.Location = new System.Drawing.Point(7, 442);
            this.Endereço.Name = "Endereço";
            this.Endereço.Size = new System.Drawing.Size(215, 298);
            this.Endereço.TabIndex = 24;
            this.Endereço.TabStop = false;
            this.Endereço.Text = "Endereço";
            this.Endereço.Visible = false;
            this.Endereço.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 253);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Estado";
            // 
            // txbEstado
            // 
            this.txbEstado.Location = new System.Drawing.Point(5, 269);
            this.txbEstado.Name = "txbEstado";
            this.txbEstado.Size = new System.Drawing.Size(141, 20);
            this.txbEstado.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 214);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Cidade";
            // 
            // txbCidade
            // 
            this.txbCidade.Location = new System.Drawing.Point(5, 230);
            this.txbCidade.Name = "txbCidade";
            this.txbCidade.Size = new System.Drawing.Size(141, 20);
            this.txbCidade.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "CEP";
            // 
            // txbCEP
            // 
            this.txbCEP.Location = new System.Drawing.Point(5, 191);
            this.txbCEP.Name = "txbCEP";
            this.txbCEP.Size = new System.Drawing.Size(141, 20);
            this.txbCEP.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Bairro";
            // 
            // txbBairro
            // 
            this.txbBairro.Location = new System.Drawing.Point(5, 152);
            this.txbBairro.Name = "txbBairro";
            this.txbBairro.Size = new System.Drawing.Size(141, 20);
            this.txbBairro.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Complemento";
            // 
            // txbComplemento
            // 
            this.txbComplemento.Location = new System.Drawing.Point(5, 113);
            this.txbComplemento.Name = "txbComplemento";
            this.txbComplemento.Size = new System.Drawing.Size(141, 20);
            this.txbComplemento.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Numero";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Rua";
            // 
            // txbNumero
            // 
            this.txbNumero.Location = new System.Drawing.Point(5, 74);
            this.txbNumero.Name = "txbNumero";
            this.txbNumero.Size = new System.Drawing.Size(141, 20);
            this.txbNumero.TabIndex = 3;
            // 
            // txbRua
            // 
            this.txbRua.Location = new System.Drawing.Point(5, 35);
            this.txbRua.Name = "txbRua";
            this.txbRua.Size = new System.Drawing.Size(141, 20);
            this.txbRua.TabIndex = 2;
            // 
            // Usuario
            // 
            this.Usuario.Controls.Add(this.lbSenha);
            this.Usuario.Controls.Add(this.label10);
            this.Usuario.Controls.Add(this.label2);
            this.Usuario.Controls.Add(this.Telefone);
            this.Usuario.Controls.Add(this.txbTelefone);
            this.Usuario.Controls.Add(this.txbSenha);
            this.Usuario.Controls.Add(this.txbUsuario);
            this.Usuario.Controls.Add(this.txbEmail);
            this.Usuario.Controls.Add(this.txbNome);
            this.Usuario.Location = new System.Drawing.Point(7, 7);
            this.Usuario.Name = "Usuario";
            this.Usuario.Size = new System.Drawing.Size(215, 208);
            this.Usuario.TabIndex = 23;
            this.Usuario.TabStop = false;
            this.Usuario.Text = "Usuario";
            this.Usuario.Enter += new System.EventHandler(this.Usuario_Enter);
            // 
            // lbSenha
            // 
            this.lbSenha.AutoSize = true;
            this.lbSenha.Location = new System.Drawing.Point(8, 162);
            this.lbSenha.Name = "lbSenha";
            this.lbSenha.Size = new System.Drawing.Size(41, 13);
            this.lbSenha.TabIndex = 20;
            this.lbSenha.Text = "Senha:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 123);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Email:";
            // 
            // Telefone
            // 
            this.Telefone.AutoSize = true;
            this.Telefone.Location = new System.Drawing.Point(8, 44);
            this.Telefone.Name = "Telefone";
            this.Telefone.Size = new System.Drawing.Size(52, 13);
            this.Telefone.TabIndex = 17;
            this.Telefone.Text = "Telefone:";
            // 
            // txbTelefone
            // 
            this.txbTelefone.Location = new System.Drawing.Point(8, 58);
            this.txbTelefone.Mask = "(00)00000-0000";
            this.txbTelefone.Name = "txbTelefone";
            this.txbTelefone.Size = new System.Drawing.Size(100, 20);
            this.txbTelefone.TabIndex = 16;
            // 
            // txbSenha
            // 
            this.txbSenha.Location = new System.Drawing.Point(9, 178);
            this.txbSenha.Name = "txbSenha";
            this.txbSenha.Size = new System.Drawing.Size(106, 20);
            this.txbSenha.TabIndex = 10;
            this.txbSenha.Enter += new System.EventHandler(this.txbSenha_Enter_1);
            // 
            // txbUsuario
            // 
            this.txbUsuario.Location = new System.Drawing.Point(9, 139);
            this.txbUsuario.Name = "txbUsuario";
            this.txbUsuario.Size = new System.Drawing.Size(106, 20);
            this.txbUsuario.TabIndex = 9;
            this.txbUsuario.Enter += new System.EventHandler(this.txbUsuario_Enter_1);
            // 
            // txbEmail
            // 
            this.txbEmail.Location = new System.Drawing.Point(8, 100);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(141, 20);
            this.txbEmail.TabIndex = 6;
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(8, 21);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(141, 20);
            this.txbNome.TabIndex = 2;
            this.txbNome.Text = "Nome Completo";
            this.txbNome.Enter += new System.EventHandler(this.txbNome_Enter_1);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(2, 158);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(207, 40);
            this.textBox1.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Ramo de Atuação";
            // 
            // Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(244, 411);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.botoes);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Cadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.Cadastro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.botoes.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.Sobre.ResumeLayout(false);
            this.Sobre.PerformLayout();
            this.Endereço.ResumeLayout(false);
            this.Endereço.PerformLayout();
            this.Usuario.ResumeLayout(false);
            this.Usuario.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox Endereço;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbCEP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbBairro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbComplemento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbNumero;
        private System.Windows.Forms.TextBox txbRua;
        private System.Windows.Forms.GroupBox Usuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Telefone;
        private System.Windows.Forms.MaskedTextBox txbTelefone;
        private System.Windows.Forms.TextBox txbSenha;
        private System.Windows.Forms.TextBox txbUsuario;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.Panel botoes;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txbCidade;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txbEstado;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbSenha;
        private System.Windows.Forms.GroupBox Sobre;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}