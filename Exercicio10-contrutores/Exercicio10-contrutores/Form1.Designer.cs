
namespace Exercicio10_contrutores
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtTitular = new System.Windows.Forms.TextBox();
            this.txtConta = new System.Windows.Forms.MaskedTextBox();
            this.txtAgencia = new System.Windows.Forms.MaskedTextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnDepositar = new System.Windows.Forms.Button();
            this.btnSacar = new System.Windows.Forms.Button();
            this.btnCadastraNovo = new System.Windows.Forms.Button();
            this.txtTransacao = new System.Windows.Forms.TextBox();
            this.txtMoeda = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtTitular
            // 
            this.txtTitular.Location = new System.Drawing.Point(94, 146);
            this.txtTitular.Name = "txtTitular";
            this.txtTitular.Size = new System.Drawing.Size(289, 29);
            this.txtTitular.TabIndex = 19;
            // 
            // txtConta
            // 
            this.txtConta.Location = new System.Drawing.Point(94, 102);
            this.txtConta.Mask = "999999999-9";
            this.txtConta.Name = "txtConta";
            this.txtConta.Size = new System.Drawing.Size(289, 29);
            this.txtConta.TabIndex = 18;
            // 
            // txtAgencia
            // 
            this.txtAgencia.HideSelection = false;
            this.txtAgencia.Location = new System.Drawing.Point(94, 61);
            this.txtAgencia.Mask = "0000-9";
            this.txtAgencia.Name = "txtAgencia";
            this.txtAgencia.Size = new System.Drawing.Size(128, 29);
            this.txtAgencia.TabIndex = 17;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(236, 246);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(147, 32);
            this.btnLimpar.TabIndex = 16;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(35, 249);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(148, 32);
            this.btnSalvar.TabIndex = 15;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 21);
            this.label4.TabIndex = 14;
            this.label4.Text = "Titular";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 21);
            this.label3.TabIndex = 13;
            this.label3.Text = "Conta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 21);
            this.label2.TabIndex = 12;
            this.label2.Text = "Agência";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(145, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 30);
            this.label1.TabIndex = 11;
            this.label1.Text = "Criar Conta";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1, 186);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 21);
            this.label7.TabIndex = 22;
            this.label7.Text = "Saldo Atual:";
            // 
            // btnDepositar
            // 
            this.btnDepositar.Location = new System.Drawing.Point(236, 234);
            this.btnDepositar.Name = "btnDepositar";
            this.btnDepositar.Size = new System.Drawing.Size(148, 32);
            this.btnDepositar.TabIndex = 24;
            this.btnDepositar.Text = "Depositar";
            this.btnDepositar.UseVisualStyleBackColor = true;
            this.btnDepositar.Visible = false;
            this.btnDepositar.Click += new System.EventHandler(this.btnDepositar_Click);
            // 
            // btnSacar
            // 
            this.btnSacar.Location = new System.Drawing.Point(236, 281);
            this.btnSacar.Name = "btnSacar";
            this.btnSacar.Size = new System.Drawing.Size(147, 32);
            this.btnSacar.TabIndex = 25;
            this.btnSacar.Text = "Sacar";
            this.btnSacar.UseVisualStyleBackColor = true;
            this.btnSacar.Visible = false;
            this.btnSacar.Click += new System.EventHandler(this.btnSacar_Click);
            // 
            // btnCadastraNovo
            // 
            this.btnCadastraNovo.Location = new System.Drawing.Point(-1, -1);
            this.btnCadastraNovo.Name = "btnCadastraNovo";
            this.btnCadastraNovo.Size = new System.Drawing.Size(124, 30);
            this.btnCadastraNovo.TabIndex = 26;
            this.btnCadastraNovo.Text = "Cadastrar novo";
            this.btnCadastraNovo.UseVisualStyleBackColor = true;
            this.btnCadastraNovo.Visible = false;
            this.btnCadastraNovo.Click += new System.EventHandler(this.btnCadastraNovo_Click);
            // 
            // txtTransacao
            // 
            this.txtTransacao.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtTransacao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTransacao.Location = new System.Drawing.Point(50, 260);
            this.txtTransacao.Name = "txtTransacao";
            this.txtTransacao.Size = new System.Drawing.Size(172, 22);
            this.txtTransacao.TabIndex = 27;
            this.txtTransacao.Visible = false;
            // 
            // txtMoeda
            // 
            this.txtMoeda.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtMoeda.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMoeda.Location = new System.Drawing.Point(25, 260);
            this.txtMoeda.Name = "txtMoeda";
            this.txtMoeda.ReadOnly = true;
            this.txtMoeda.Size = new System.Drawing.Size(33, 22);
            this.txtMoeda.TabIndex = 28;
            this.txtMoeda.Text = "R$ ";
            this.txtMoeda.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(91, 187);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(27, 22);
            this.textBox1.TabIndex = 29;
            this.textBox1.Text = "R$ ";
            // 
            // txtSaldo
            // 
            this.txtSaldo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtSaldo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSaldo.Location = new System.Drawing.Point(114, 187);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.ReadOnly = true;
            this.txtSaldo.Size = new System.Drawing.Size(140, 22);
            this.txtSaldo.TabIndex = 30;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 326);
            this.Controls.Add(this.txtSaldo);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtMoeda);
            this.Controls.Add(this.txtTransacao);
            this.Controls.Add(this.btnCadastraNovo);
            this.Controls.Add(this.btnSacar);
            this.Controls.Add(this.btnDepositar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTitular);
            this.Controls.Add(this.txtConta);
            this.Controls.Add(this.txtAgencia);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTitular;
        private System.Windows.Forms.MaskedTextBox txtConta;
        private System.Windows.Forms.MaskedTextBox txtAgencia;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnDepositar;
        private System.Windows.Forms.Button btnSacar;
        private System.Windows.Forms.Button btnCadastraNovo;
        private System.Windows.Forms.TextBox txtTransacao;
        private System.Windows.Forms.TextBox txtMoeda;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtSaldo;
    }
}

