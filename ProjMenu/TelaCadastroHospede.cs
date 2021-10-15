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
    public partial class TelaCadastroHospede : Form
    {
        public TelaCadastroHospede()
        {
            InitializeComponent();
        }

        // Conexão com o banco    
        private static string strCon = @"Data Source=DESKTOP-SIMS6N4\SQLEXPRESS02;Initial Catalog=tbUsuario;Integrated Security=True";
        private static SqlConnection sqlcon = new SqlConnection(strCon);
        private string strsql = string.Empty;

        public static string StrCon { get; private set; }

        // Cadastrando Hóspedes
        private void btnInserir_Click(object sender, EventArgs e)
        {
            verificar();
            strsql = "INSERT INTO Hospede (NomeHospede, CpfHospede, DataCheckIn, DataCheckOut, NumeroQuarto) VALUES (@NomeHospede, @CpfHospede, @DataCheckIn, @DataCheckOut, @NumeroQuarto)";

            sqlcon = new SqlConnection(strCon);

            SqlCommand comando = new SqlCommand(strsql, sqlcon);

            comando.Parameters.Add("@NomeHospede", SqlDbType.VarChar).Value = txtNome.Text;
            comando.Parameters.Add("@CpfHospede", SqlDbType.VarChar).Value = txtCPF.Text;
            comando.Parameters.Add("@DataCheckIn", SqlDbType.Date).Value = txtDataCheckIn.Text;
            comando.Parameters.Add("@DataCheckOut", SqlDbType.Date).Value = txtDataCheckOut.Text;
            comando.Parameters.Add("@NumeroQuarto", SqlDbType.VarChar).Value = txtNumeroQuarto.Text;

            try
            {
                // Menssagem para CADASTRADO COM SUCESSO
                sqlcon.Open();

                comando.ExecuteNonQuery();

                MessageBox.Show("Cadastrado com Sucesso!");
                txtNome.Text = ""; // Para limpar as textbox depois de serem inseridas
                txtCPF.Text = "";
                txtDataCheckIn.Text = "";
                txtDataCheckOut.Text = "";
                txtNumeroQuarto.Text = "";
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
            if (txtNome.Text == "" && txtCPF.Text == "" && txtDataCheckIn.Text == "" && txtDataCheckOut.Text == "" && txtNumeroQuarto.Text == "")
            {
                MessageBox.Show("Preencha os campos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNome.Select();
            }
        }

        private void TelaCadastroHospede_FormClosed(object sender, FormClosedEventArgs e)
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