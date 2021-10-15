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
    public partial class TelaCadastroFuncionario : Form
    {
        public TelaCadastroFuncionario()
        {
            InitializeComponent();
        }

        // Conexão com o banco    
        private static string strCon = @"Data Source=DESKTOP-SIMS6N4\SQLEXPRESS02;Initial Catalog=tbUsuario;Integrated Security=True";
        private static SqlConnection sqlcon = new SqlConnection(strCon);
        private string strsql = string.Empty;

        public static string StrCon { get; private set; }

        // Cadastrando Funcionários
        private void btnInserir_Click(object sender, EventArgs e)
        {
            verificar();
            strsql = "INSERT INTO Funcionario (NomeFuncionario, CpfFuncionario, DataNascimento, DataContartacao, Status) VALUES (@NomeFuncionario, @CpfFuncionario, @DataNascimento, @DataContratacao, @Status)";

            sqlcon = new SqlConnection(strCon);

            SqlCommand comando = new SqlCommand(strsql, sqlcon);

            comando.Parameters.Add("@NomeFuncionario", SqlDbType.VarChar).Value = txtNome.Text;
            comando.Parameters.Add("@CpfFuncionario", SqlDbType.VarChar).Value = txtCPF.Text;
            comando.Parameters.Add("@DataNascimento", SqlDbType.Date).Value = txtDataNascimento.Text;
            comando.Parameters.Add("@DataContratacao", SqlDbType.Date).Value = txtDataContratacao.Text;
            comando.Parameters.Add("@Status", SqlDbType.VarChar).Value = txtStatus.Text;

            try
            {
                // Menssagem para CADASTRADO COM SUCESSO
                sqlcon.Open();

                comando.ExecuteNonQuery();

                MessageBox.Show("Cadastrado com Sucesso!");
                txtNome.Text = ""; // Para limpar as textbox depois de serem inseridas
                txtCPF.Text = "";
                txtDataNascimento.Text = "";
                txtDataContratacao.Text = "";
                txtStatus.Text = "";
                txtNome.Select();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                sqlcon.Close();
            }
        }

        // Verificação das textbox
        void verificar()
        {
            if (txtNome.Text == "" && txtCPF.Text == "" && txtDataNascimento.Text == "" && txtDataContratacao.Text == "" && txtStatus.Text == "")
            {
                MessageBox.Show("Preencha os campos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNome.Select();
            }
        }

        private void TelaCadastroFuncionario_FormClosed(object sender, FormClosedEventArgs e)
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