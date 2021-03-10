using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio10_contrutores
{
    public partial class Form1 : Form
    {
        private ContaCorrente contaCorrente;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                string agencia = txtAgencia.Text;
                string numContaCorrente = txtConta.Text;
                string titular = txtTitular.Text;

                contaCorrente = new ContaCorrente(agencia, numContaCorrente, titular);

                MessageBox.Show("Conta do Banco Salva");

                txtSaldo.Text = contaCorrente.Saldo.ToString();

                txtAgencia.ReadOnly = true;
                txtConta.ReadOnly = true;
                txtTitular.ReadOnly = true;
                btnSalvar.Visible = false;
                btnLimpar.Visible = false;
                btnDepositar.Visible = true;
                btnSacar.Visible = true;
                btnCadastraNovo.Visible = true;
                txtTransacao.Visible = true;
                txtMoeda.Visible = true;
                txtTransacao.Focus();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void btnCadastraNovo_Click(object sender, EventArgs e)
        {
            txtAgencia.ReadOnly = false;
            txtConta.ReadOnly = false;
            txtTitular.ReadOnly = false;
            txtAgencia.Clear();
            txtConta.Clear();
            txtTitular.Clear();
            btnSalvar.Visible = true;
            btnLimpar.Visible = true;
            btnDepositar.Visible = false;
            btnSacar.Visible = false;
            btnCadastraNovo.Visible = false;
            txtTransacao.Clear();
            txtTransacao.Visible = false;
            txtMoeda.Visible = false;
        }

        private void btnDepositar_Click(object sender, EventArgs e)
        {
            try
            {
                contaCorrente.Depositar(Convert.ToDouble(txtTransacao.Text));
                txtSaldo.Text = contaCorrente.Saldo.ToString();
                txtTransacao.Clear();
                txtTransacao.Focus();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void btnSacar_Click(object sender, EventArgs e)
        {
            try
            {
                contaCorrente.Sacar(Convert.ToDouble(txtTransacao.Text));
                txtSaldo.Text = contaCorrente.Saldo.ToString();
                txtTransacao.Clear();
                txtTransacao.Focus();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
    }
}