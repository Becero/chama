namespace chama
{
    partial class CadastroEmprego
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
            this.txbDescrição = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.cbxHomem = new System.Windows.Forms.CheckBox();
            this.cbxMulher = new System.Windows.Forms.CheckBox();
            this.cbxOutro = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txbDescrição
            // 
            this.txbDescrição.Location = new System.Drawing.Point(24, 200);
            this.txbDescrição.Multiline = true;
            this.txbDescrição.Name = "txbDescrição";
            this.txbDescrição.Size = new System.Drawing.Size(189, 85);
            this.txbDescrição.TabIndex = 0;
            this.txbDescrição.Text = "Descrição";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(25, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(188, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Vaga";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(25, 61);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(80, 20);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "Valor";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // cbxHomem
            // 
            this.cbxHomem.AutoSize = true;
            this.cbxHomem.Location = new System.Drawing.Point(27, 115);
            this.cbxHomem.Name = "cbxHomem";
            this.cbxHomem.Size = new System.Drawing.Size(62, 17);
            this.cbxHomem.TabIndex = 7;
            this.cbxHomem.Text = "Homem";
            this.cbxHomem.UseVisualStyleBackColor = true;
            // 
            // cbxMulher
            // 
            this.cbxMulher.AutoSize = true;
            this.cbxMulher.Location = new System.Drawing.Point(27, 138);
            this.cbxMulher.Name = "cbxMulher";
            this.cbxMulher.Size = new System.Drawing.Size(58, 17);
            this.cbxMulher.TabIndex = 8;
            this.cbxMulher.Text = "Mulher";
            this.cbxMulher.UseVisualStyleBackColor = true;
            // 
            // cbxOutro
            // 
            this.cbxOutro.AutoSize = true;
            this.cbxOutro.Location = new System.Drawing.Point(27, 161);
            this.cbxOutro.Name = "cbxOutro";
            this.cbxOutro.Size = new System.Drawing.Size(52, 17);
            this.cbxOutro.TabIndex = 9;
            this.cbxOutro.Text = "Outro";
            this.cbxOutro.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Genero:";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(131, 335);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(82, 23);
            this.btnLimpar.TabIndex = 18;
            this.btnLimpar.Text = "LIMPAR";
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(23, 334);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(82, 23);
            this.btnSalvar.TabIndex = 19;
            this.btnSalvar.Text = "SALVAR";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.btnFechar);
            this.panel1.Controls.Add(this.btnVoltar);
            this.panel1.Location = new System.Drawing.Point(2, 377);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(243, 35);
            this.panel1.TabIndex = 21;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(174, 6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(49, 23);
            this.button3.TabIndex = 20;
            this.button3.Text = "●";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(97, 6);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(49, 23);
            this.btnFechar.TabIndex = 19;
            this.btnFechar.Text = "☐";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(18, 6);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(49, 23);
            this.btnVoltar.TabIndex = 18;
            this.btnVoltar.Text = "◀";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // CadastroEmprego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 411);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxOutro);
            this.Controls.Add(this.cbxMulher);
            this.Controls.Add(this.cbxHomem);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txbDescrição);
            this.Name = "CadastroEmprego";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CadastroEmprego";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbDescrição;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.CheckBox cbxHomem;
        private System.Windows.Forms.CheckBox cbxMulher;
        private System.Windows.Forms.CheckBox cbxOutro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnVoltar;
    }
}