using System;
using System.Windows.Forms;

namespace Exercicio4_exercicios_propriedades
{
    public partial class Form1 : Form
    {
        private Funcionario f;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            f = new Funcionario();
            errorProvider1.Clear();

            btnExibir.Visible = true;
            try
            {
                f.Codigo = Convert.ToInt32(txtCodigo.Text);
            }
            catch (Exception erro)
            {
                errorProvider1.SetError(txtCodigo, erro.Message);
                btnExibir.Visible = false;
            }

            try
            {
                f.Nome = txtNome.Text;
            }
            catch (Exception erro)
            {
                errorProvider1.SetError(txtNome, erro.Message);
                btnExibir.Visible = false;
            }

            try
            {
                f.Rg = txtRg.Text;
            }
            catch (Exception erro)
            {
                errorProvider1.SetError(txtRg, erro.Message);
                btnExibir.Visible = false;
            }

            try
            {
                f.Salario = Convert.ToDouble(txtSalario.Text);
            }
            catch (Exception erro)
            {
                errorProvider1.SetError(txtSalario, erro.Message);
                btnExibir.Visible = false;
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtInfo.Clear();
            txtCodigo.Clear();
            txtNome.Clear();
            txtRg.Clear();
            txtSalario.Clear();
            errorProvider1.Clear();
            btnExibir.Visible = false;
        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
            if (f.Nome != null)
                txtInfo.Text = $"Código: {f.Codigo}"
                            + Environment.NewLine + $"Nome: {f.Nome}"
                            + Environment.NewLine + $"RG: {f.Rg}"
                            + Environment.NewLine + $"Desconto do INSS: {f.Inss}"
                            + Environment.NewLine + $"Salario Bruto: {f.Salario + f.Inss}"
                            + Environment.NewLine + $"Salario liquido: {f.Salario}";
        }
    }
}