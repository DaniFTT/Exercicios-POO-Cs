using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio9_construtores
{
    public partial class Form1 : Form
    {
        private Funcionario f;
        private bool certo;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click_1(object sender, EventArgs e)
        {
            certo = true;
            try
            {
                int codigo = Convert.ToInt32(txtCodigo.Text);
                string nome = txtNome.Text;
                string rg = txtRg.Text;
                double salario = Convert.ToDouble(txtSalario.Text);
                f = new Funcionario(codigo, nome, rg, salario);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
                certo = false;
            }
        }

        private void btnExibir_Click_1(object sender, EventArgs e)
        {
            if (certo == true)
            {
                txtInfo.Text = $"Código: {f.Codigo}"
                                + Environment.NewLine + $"Nome: {f.Nome}"
                                + Environment.NewLine + $"RG: {f.Rg}"
                                + Environment.NewLine + $"Desconto do INSS: {f.GetInss()}"
                                + Environment.NewLine + $"Salario Bruto: {f.Salario}"
                                + Environment.NewLine + $"Salario liquido: {f.GetSalario()}";
            }
            else
            {
                txtInfo.Text = "Corrija os erros no cadastro";
            }
        }

        private void btnLimpar_Click_1(object sender, EventArgs e)
        {
            txtInfo.Clear();
            txtCodigo.Clear();
            txtNome.Clear();
            txtRg.Clear();
            txtSalario.Clear();
            errorProvider1.Clear();
        }
    }
}