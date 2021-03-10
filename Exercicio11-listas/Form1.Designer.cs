
namespace Exercicio11_listas
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
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtMoeda = new System.Windows.Forms.TextBox();
            this.txtTransacao = new System.Windows.Forms.TextBox();
            this.btnCadastraNovo = new System.Windows.Forms.Button();
            this.btnSacar = new System.Windows.Forms.Button();
            this.btnDepositar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTitular = new System.Windows.Forms.TextBox();
            this.txtConta = new System.Windows.Forms.MaskedTextBox();
            this.txtAgencia = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbTransacao = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbCriacao = new System.Windows.Forms.GroupBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lblListaCount = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtContaPesquisa = new System.Windows.Forms.MaskedTextBox();
            this.btnListarContas = new System.Windows.Forms.Button();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.gbTransacao.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gbCriacao.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSaldo
            // 
            this.txtSaldo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtSaldo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSaldo.Location = new System.Drawing.Point(121, 190);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.ReadOnly = true;
            this.txtSaldo.Size = new System.Drawing.Size(140, 13);
            this.txtSaldo.TabIndex = 47;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(98, 190);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(27, 13);
            this.textBox1.TabIndex = 46;
            this.textBox1.Text = "R$ ";
            // 
            // txtMoeda
            // 
            this.txtMoeda.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtMoeda.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMoeda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMoeda.Location = new System.Drawing.Point(20, 41);
            this.txtMoeda.Name = "txtMoeda";
            this.txtMoeda.ReadOnly = true;
            this.txtMoeda.Size = new System.Drawing.Size(33, 19);
            this.txtMoeda.TabIndex = 45;
            this.txtMoeda.Text = "R$ ";
            // 
            // txtTransacao
            // 
            this.txtTransacao.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtTransacao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTransacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTransacao.Location = new System.Drawing.Point(45, 41);
            this.txtTransacao.Name = "txtTransacao";
            this.txtTransacao.Size = new System.Drawing.Size(172, 19);
            this.txtTransacao.TabIndex = 44;
            // 
            // btnCadastraNovo
            // 
            this.btnCadastraNovo.Location = new System.Drawing.Point(10, 15);
            this.btnCadastraNovo.Name = "btnCadastraNovo";
            this.btnCadastraNovo.Size = new System.Drawing.Size(124, 30);
            this.btnCadastraNovo.TabIndex = 43;
            this.btnCadastraNovo.Text = "Cadastrar novo";
            this.btnCadastraNovo.UseVisualStyleBackColor = true;
            this.btnCadastraNovo.Visible = false;
            this.btnCadastraNovo.Click += new System.EventHandler(this.btnCadastraNovo_Click_1);
            // 
            // btnSacar
            // 
            this.btnSacar.Location = new System.Drawing.Point(249, 58);
            this.btnSacar.Name = "btnSacar";
            this.btnSacar.Size = new System.Drawing.Size(147, 32);
            this.btnSacar.TabIndex = 42;
            this.btnSacar.Text = "Sacar";
            this.btnSacar.UseVisualStyleBackColor = true;
            this.btnSacar.Click += new System.EventHandler(this.btnSacar_Click_1);
            // 
            // btnDepositar
            // 
            this.btnDepositar.Location = new System.Drawing.Point(249, 11);
            this.btnDepositar.Name = "btnDepositar";
            this.btnDepositar.Size = new System.Drawing.Size(148, 32);
            this.btnDepositar.TabIndex = 41;
            this.btnDepositar.Text = "Depositar";
            this.btnDepositar.UseVisualStyleBackColor = true;
            this.btnDepositar.Click += new System.EventHandler(this.btnDepositar_Click_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 40;
            this.label7.Text = "Saldo Atual:";
            // 
            // txtTitular
            // 
            this.txtTitular.Location = new System.Drawing.Point(101, 149);
            this.txtTitular.Name = "txtTitular";
            this.txtTitular.Size = new System.Drawing.Size(339, 20);
            this.txtTitular.TabIndex = 39;
            // 
            // txtConta
            // 
            this.txtConta.Location = new System.Drawing.Point(101, 105);
            this.txtConta.Mask = "999999999-9";
            this.txtConta.Name = "txtConta";
            this.txtConta.Size = new System.Drawing.Size(128, 20);
            this.txtConta.TabIndex = 38;
            // 
            // txtAgencia
            // 
            this.txtAgencia.HideSelection = false;
            this.txtAgencia.Location = new System.Drawing.Point(101, 64);
            this.txtAgencia.Mask = "0000-9";
            this.txtAgencia.Name = "txtAgencia";
            this.txtAgencia.Size = new System.Drawing.Size(128, 20);
            this.txtAgencia.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "Titular";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "Conta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Agência";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(183, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 30);
            this.label1.TabIndex = 31;
            this.label1.Text = "Criar Conta";
            // 
            // gbTransacao
            // 
            this.gbTransacao.Controls.Add(this.btnDepositar);
            this.gbTransacao.Controls.Add(this.btnSacar);
            this.gbTransacao.Controls.Add(this.txtTransacao);
            this.gbTransacao.Controls.Add(this.txtMoeda);
            this.gbTransacao.Location = new System.Drawing.Point(10, 228);
            this.gbTransacao.Name = "gbTransacao";
            this.gbTransacao.Size = new System.Drawing.Size(440, 100);
            this.gbTransacao.TabIndex = 49;
            this.gbTransacao.TabStop = false;
            this.gbTransacao.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDeletar);
            this.panel1.Controls.Add(this.btnCadastraNovo);
            this.panel1.Controls.Add(this.gbCriacao);
            this.panel1.Controls.Add(this.lblListaCount);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtSaldo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtConta);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtAgencia);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtTitular);
            this.panel1.Controls.Add(this.gbTransacao);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(472, 353);
            this.panel1.TabIndex = 53;
            // 
            // gbCriacao
            // 
            this.gbCriacao.Controls.Add(this.btnSalvar);
            this.gbCriacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbCriacao.Location = new System.Drawing.Point(10, 228);
            this.gbCriacao.Name = "gbCriacao";
            this.gbCriacao.Size = new System.Drawing.Size(443, 100);
            this.gbCriacao.TabIndex = 54;
            this.gbCriacao.TabStop = false;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSalvar.Location = new System.Drawing.Point(16, 36);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(414, 32);
            this.btnSalvar.TabIndex = 35;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click_1);
            // 
            // lblListaCount
            // 
            this.lblListaCount.AutoSize = true;
            this.lblListaCount.Location = new System.Drawing.Point(90, 3);
            this.lblListaCount.Name = "lblListaCount";
            this.lblListaCount.Size = new System.Drawing.Size(13, 13);
            this.lblListaCount.TabIndex = 53;
            this.lblListaCount.Text = "0";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(462, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 353);
            this.panel2.TabIndex = 50;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 2);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 13);
            this.label9.TabIndex = 52;
            this.label9.Text = "Contas criadas:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 474);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 50;
            this.label5.Text = "Contas criadas:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(89, 475);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 51;
            this.label6.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(472, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(138, 20);
            this.label8.TabIndex = 55;
            this.label8.Text = "Numero da Conta:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnBuscar.Location = new System.Drawing.Point(725, 6);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(78, 27);
            this.btnBuscar.TabIndex = 56;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtContaPesquisa
            // 
            this.txtContaPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContaPesquisa.Location = new System.Drawing.Point(607, 6);
            this.txtContaPesquisa.Mask = "999999999-9";
            this.txtContaPesquisa.Name = "txtContaPesquisa";
            this.txtContaPesquisa.Size = new System.Drawing.Size(109, 26);
            this.txtContaPesquisa.TabIndex = 57;
            // 
            // btnListarContas
            // 
            this.btnListarContas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnListarContas.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnListarContas.Location = new System.Drawing.Point(809, 6);
            this.btnListarContas.Name = "btnListarContas";
            this.btnListarContas.Size = new System.Drawing.Size(87, 27);
            this.btnListarContas.TabIndex = 58;
            this.btnListarContas.Text = "Listar todos";
            this.btnListarContas.UseVisualStyleBackColor = true;
            this.btnListarContas.Click += new System.EventHandler(this.btnListarContas_Click);
            // 
            // btnDeletar
            // 
            this.btnDeletar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDeletar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnDeletar.Location = new System.Drawing.Point(309, 180);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(131, 32);
            this.btnDeletar.TabIndex = 36;
            this.btnDeletar.Text = "Deletar Conta";
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Visible = false;
            this.btnDeletar.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(481, 55);
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ReadOnly = true;
            this.txtResultado.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResultado.Size = new System.Drawing.Size(418, 286);
            this.txtResultado.TabIndex = 59;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 353);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.btnListarContas);
            this.Controls.Add(this.txtContaPesquisa);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbTransacao.ResumeLayout(false);
            this.gbTransacao.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbCriacao.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtMoeda;
        private System.Windows.Forms.TextBox txtTransacao;
        private System.Windows.Forms.Button btnCadastraNovo;
        private System.Windows.Forms.Button btnSacar;
        private System.Windows.Forms.Button btnDepositar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTitular;
        private System.Windows.Forms.MaskedTextBox txtConta;
        private System.Windows.Forms.MaskedTextBox txtAgencia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbTransacao;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblListaCount;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox gbCriacao;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.MaskedTextBox txtContaPesquisa;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.Button btnListarContas;
        private System.Windows.Forms.TextBox txtResultado;
    }
}

