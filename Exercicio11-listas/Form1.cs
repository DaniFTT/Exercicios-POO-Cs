using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio11_listas
{
    public partial class Form1 : Form
    {
        private List<ContaCorrente> listaContas = new List<ContaCorrente>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click_1(object sender, EventArgs e)
        {
            try
            {
                string agencia = txtAgencia.Text;
                string numContaCorrente = txtConta.Text;
                string titular = txtTitular.Text;

                ContaCorrente conta = listaContas.Find(c => c.Conta == numContaCorrente);
                if(conta == null)
                {
                    listaContas.Add(new ContaCorrente(agencia, numContaCorrente, titular));
                    MessageBox.Show("Conta do Banco Salva");
                    txtSaldo.Text = "0";

                    txtAgencia.ReadOnly = true;
                    txtConta.ReadOnly = true;
                    txtTitular.ReadOnly = true;
                    gbCriacao.Visible = false;
                    gbTransacao.Visible = true;
                    btnCadastraNovo.Visible = true;
                    txtTransacao.Focus();
                    lblListaCount.Text = listaContas.Count().ToString();
                    btnDeletar.Visible = true;
                }
                else
                {
                    MessageBox.Show("O numero da Conta já Existe");
                }
             
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void btnDepositar_Click_1(object sender, EventArgs e)
        {
            try
            {
                ContaCorrente conta = listaContas.Find(c => c.Conta == txtConta.Text);
                if(conta != null)
                {
                    conta.Depositar(Convert.ToDouble(txtTransacao.Text));
                    txtSaldo.Text = conta.Saldo.ToString();
                    txtTransacao.Clear();
                    txtTransacao.Focus();
                }

              
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void btnSacar_Click_1(object sender, EventArgs e)
        {
            try
            {
                ContaCorrente conta = listaContas.Find(c => c.Conta == txtConta.Text);
                if (conta != null)
                {
                    conta.Sacar(Convert.ToDouble(txtTransacao.Text));
                    txtSaldo.Text = conta.Saldo.ToString();
                    txtTransacao.Clear();
                    txtTransacao.Focus();
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void btnCadastraNovo_Click_1(object sender, EventArgs e)
        {
            txtAgencia.ReadOnly = false;
            txtConta.ReadOnly = false;
            txtTitular.ReadOnly = false;
            txtAgencia.Clear();
            txtConta.Clear();
            txtTitular.Clear();
            gbCriacao.Visible = true;
            gbTransacao.Visible = false;
            btnCadastraNovo.Visible = false;
            txtTransacao.Clear();
            txtSaldo.Text = "0";
            btnDeletar.Visible = false;

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ContaCorrente conta = listaContas.Find(c => c.Conta == txtContaPesquisa.Text);
            if (conta != null)
            {
                txtAgencia.ReadOnly = true;
                txtConta.ReadOnly = true;
                txtTitular.ReadOnly = true;
                txtAgencia.Text = conta.Agencia.ToString();
                txtConta.Text = conta.Conta.ToString();
                txtTitular.Text = conta.Titular.ToString();
                txtSaldo.Text = conta.Saldo.ToString();

                txtTransacao.Clear();
                gbCriacao.Visible = false;
                gbTransacao.Visible = true;
                btnDeletar.Visible = true;
            }
            else
                MessageBox.Show("Numero de Conta não encontrado");
        }

        private void btnListarContas_Click(object sender, EventArgs e)
        {
            txtResultado.Clear();
            if (listaContas.Count == 0)
                MessageBox.Show("Não há nenhuma conta cadastrada!");
            else
            {
                foreach (var item in listaContas)
                {
                    txtResultado.Text += $"Titular: {item.Titular}"
                        + Environment.NewLine + $"Conta corrente: {item.Conta}"
                        + Environment.NewLine + $"Agência: {item.Agencia}"
                        + Environment.NewLine + $"Saldo Atual: {item.Saldo}"
                        + Environment.NewLine
                        + "----------------------------------------------------------"
                        + Environment.NewLine;
                }
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ContaCorrente conta = listaContas.Find(c => c.Conta == txtConta.Text);
            listaContas.Remove(conta);
            MessageBox.Show($"A Conta Corrente: {conta.Conta} do Titular: {conta.Titular} foi deletada");

            txtAgencia.ReadOnly = false;
            txtConta.ReadOnly = false;
            txtTitular.ReadOnly = false;
            txtAgencia.Clear();
            txtConta.Clear();
            txtTitular.Clear();
            gbCriacao.Visible = true;
            gbTransacao.Visible = false;
            btnCadastraNovo.Visible = false;
            txtTransacao.Clear();
            txtSaldo.Text = "0";
            btnDeletar.Visible = false;
        }
    }
}
