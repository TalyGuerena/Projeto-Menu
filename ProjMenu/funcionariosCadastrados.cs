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
    public partial class funcionariosCadastrados : Form
    {
        public funcionariosCadastrados()
        {
            InitializeComponent();
        }

        private void btnSelect_Click(object sender, EventArgs e) // Trazendo todos os funcionários
        {
            string strConexao = @"Data Source=DESKTOP-SIMS6N4\SQLEXPRESS02;Initial Catalog=tbUsuario;Integrated Security=True";
            string Query = "SELECT * FROM Funcionario";

            SqlConnection conexao = new SqlConnection(strConexao);
            SqlDataAdapter da = new SqlDataAdapter(Query, conexao);

            DataTable tb = new DataTable();

            da.Fill(tb);

            dgvDados.DataSource = tb;
        }

        private void funcionariosCadastrados_FormClosed(object sender, FormClosedEventArgs e)
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

        private void btnSelect2_Click(object sender, EventArgs e) // Trazendo funcionários que estão de férias
        {
            string strConexao = @"Data Source=DESKTOP-SIMS6N4\SQLEXPRESS02;Initial Catalog=tbUsuario;Integrated Security=True";
            string Query = "SELECT NomeFuncionario, CpfFuncionario, Status FROM Funcionario WHERE Status = 'F'";

            SqlConnection conexao = new SqlConnection(strConexao);
            SqlDataAdapter da = new SqlDataAdapter(Query, conexao);

            DataTable tb = new DataTable();

            da.Fill(tb);

            dgvDados.DataSource = tb;
        }
    }
}