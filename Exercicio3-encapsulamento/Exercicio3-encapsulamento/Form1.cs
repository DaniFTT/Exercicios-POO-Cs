using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio3_encapsulamento2
{
    public partial class Form1 : Form
    {
        private Funcionario f;
        private bool certo;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            certo = true;
            errorProvider1.Clear();
            f = new Funcionario();

            try
            {
                f.SetCodigo(Convert.ToInt32(txtCodigo.Text));
            }
            catch (Exception erro)
            {
                errorProvider1.SetError(txtCodigo, erro.Message);
                certo = false;
            }

            try
            {
                f.SetNome(txtNome.Text.ToString());
            }
            catch (Exception erro)
            {
                errorProvider1.SetError(txtNome, erro.Message);
                certo = false;
            }

            try
            {
                f.SetRg(txtRg.Text);
            }
            catch (Exception erro)
            {
                errorProvider1.SetError(txtRg, erro.Message);
                certo = false;
            }

            try
            {
                f.SetSalario(Convert.ToDouble(txtSalario.Text));
            }
            catch (Exception erro)
            {
                errorProvider1.SetError(txtSalario, erro.Message);
                certo = false;
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
        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
            if (certo == true)
            {
                txtInfo.Text = $"Código: {f.GetCodigo()}"
                                + Environment.NewLine + $"Nome: {f.GetNome()}"
                                + Environment.NewLine + $"RG: {f.GetRg()}"
                                + Environment.NewLine + $"Desconto do INSS: {f.GetInss()}"
                                + Environment.NewLine + $"Salario Bruto: {f.GetSalario() + f.GetInss()}"
                                + Environment.NewLine + $"Salario liquido: {f.GetSalario()}";
            }
            else
            {
                txtInfo.Text = "Corrija os erros no cadastro";
            }
        }
    }
}