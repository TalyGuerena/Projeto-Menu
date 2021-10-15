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
    public partial class DeletarFuncionario : Form
    {
        public DeletarFuncionario()
        {
            InitializeComponent();
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            string strConexao = @"Data Source=DESKTOP-SIMS6N4\SQLEXPRESS02;Initial Catalog=tbUsuario;Integrated Security=True";
            string Query = " DELETE FROM Funcionario WHERE CpfFuncionario = " + txtDeletar.Text;

            try
            {
                // Menssagem para DELETADO COM SUCESSO
                MessageBox.Show("Deletado com Sucesso!");
                txtDeletar.Text = ""; // Para limpar as textbox depois de serem inseridas
                txtDeletar.Select();
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

        private void DeletarFuncionario_FormClosed(object sender, FormClosedEventArgs e)
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