using Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroClientesDS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void textcabecalho_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Olá! Nos mande um whatsapp para (016) 99162-6800 ou e-mail para contato@dssoft.com.br. Ficaremos felizes em te atender!");
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            Pessoa pessoa = new Pessoa();
            pessoa.nome = textnome.Text;
            pessoa.sobrenome = textsobrenome.Text;
            pessoa.idade = textnascimento.Text;
            pessoa.endereco = textendereco.Text;
            pessoa.bairro = textbairro.Text;
            pessoa.cidade = textcidade.Text;
            pessoa.telefone = texttelefone.Text;

            pessoa.SalvarDados();
        }
    }
}
