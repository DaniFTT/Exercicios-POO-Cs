using System;
using System.Windows.Forms;

namespace Exercicio6_exercicios_propriedades
{
    public partial class Form1 : Form
    {
        private readonly Aluno[] vetorAluno = new Aluno[10];
        private int i = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (i <= 9)
                {
                    vetorAluno[i] = new Aluno();
                    vetorAluno[i].Nome = txtNome.Text;
                    vetorAluno[i].Nota1 = Convert.ToDouble(txtNota1.Text);
                    vetorAluno[i].Nota2 = Convert.ToDouble(txtNota2.Text);
                    i++;
                    lblCont.Text = i.ToString();
                    btnExibir.Enabled = true;
                    txtNome.Clear();
                    txtNota1.Clear();
                    txtNota2.Clear();
                }
                else
                {
                    MessageBox.Show("Os 10 alunos já foram preenchidos");
                    txtNome.Clear();
                    txtNota1.Clear();
                    txtNota2.Clear();
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
                btnExibir.Enabled = false;
            }
        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
            txtInfo.Clear();
            for (int j = 0; j < 10; j++)
            {
                if (vetorAluno[j] != null)
                {
                    txtInfo.Text += Environment.NewLine + $"Nome: {vetorAluno[j].Nome}" + Environment.NewLine + $"Média: {vetorAluno[j].Media}" + Environment.NewLine;
                }
            }
            txtNome.Focus();
            btnExibir.Enabled = false;
            label5.Visible = true;
        }
    }
}