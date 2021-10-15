using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjMenu
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ajudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_SDI Tela = new Form_SDI();
            Tela.Show();
            this.Hide();
        }

        private void novoHospedeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaCadastroHospede Tela = new TelaCadastroHospede();
            Tela.Show();
            this.Hide();
        }

        private void novoUsuárioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TelaCadastro Tela = new TelaCadastro();
            Tela.Show();
            this.Hide();
        }

        private void DeletarHospedeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeletarHospede Deletar = new DeletarHospede();
            Deletar.Show();
            this.Hide();
        }

        private void deletarFuncionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeletarFuncionario Deletar = new DeletarFuncionario();
            Deletar.Show();
            this.Hide();
        }

        private void novoFuncionárioToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            TelaCadastroFuncionario Tela = new TelaCadastroFuncionario();
            Tela.Show();
            this.Hide();
        }

        private void deletarUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeletarUsuario Deletar = new DeletarUsuario();
            Deletar.Show();
            this.Hide();
        }

        private void atualizarFuncionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AtualizarFuncionario atualizar = new AtualizarFuncionario();
            atualizar.Show();
            this.Hide();
        }

        private void atualizarHóspedeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AtualizarHospede atualizar = new AtualizarHospede();
            atualizar.Show();
            this.Hide();
        }

        private void atualizarUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AtualizarUsuario atualizar = new AtualizarUsuario();
            atualizar.Show();
            this.Hide();
        }

        private void exibirTelaDeHóspedesCadastradosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hospedesCadastrados hospede = new hospedesCadastrados();
            hospede.Show();
            this.Hide();
        }

        private void exibirTelaDeFuncionariosCadastradosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            funcionariosCadastrados funcionarios = new funcionariosCadastrados();
            funcionarios.Show();
            this.Hide();
        }
    }
}