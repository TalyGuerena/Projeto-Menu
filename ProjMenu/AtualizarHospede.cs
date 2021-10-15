using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProjMenu
{
    public partial class AtualizarHospede : Form
    {
        public AtualizarHospede()
        {
            InitializeComponent();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            string strConexao = @"Data Source=DESKTOP-SIMS6N4\SQLEXPRESS02;Initial Catalog=tbUsuario;Integrated Security=True";
            string Query = "UPDATE Hospede SET NumeroQuarto = '" + txtNumeroQuarto.Text + "' WHERE CpfHospede = " + txtCPF.Text;

            try
            {
                // Menssagem para Atualizado COM SUCESSO
                MessageBox.Show("Atualizado com Sucesso!");
                txtNumeroQuarto.Text = ""; // Para limpar as textbox depois de serem inseridas
                txtCPF.Text = "";
                txtNumeroQuarto.Select();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            SqlConnection conexao = new SqlConnection(strConexao);
            SqlCommand comando = new SqlCommand(Query, conexao);

            conexao.Open();
            comando.ExecuteNonQuery();
            conexao.Close();
        }

        private void AtualizarHospede_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms.Count == 0)
            {
                Application.Exit();
            }
            else
            {
                foreach (Form formOpen in Application.OpenForms)
                {
                    if (formOpen is Form2)
                    {
                        formOpen.Show();
                        break;
                    }
                }
            }
        }
    }
}