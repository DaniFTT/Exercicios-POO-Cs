using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio5_exercicios_propriedades
{
    public partial class Form1 : Form
    {
        private Aluno a;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            a = new Aluno();

            try
            {
                a.Nome = txtNome.Text;
                a.Nota1 = Convert.ToDouble(txtNota1.Text);
                a.Nota2 = Convert.ToDouble(txtNota2.Text);
                btnExibir.Visible = true;
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
                btnExibir.Visible = false;
            }
        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
            if (a != null)
            {
                txtInfo.Text = $"Nome: {a.Nome}" + Environment.NewLine + $"Média: {a.Media}";
            }
        }
    }
}