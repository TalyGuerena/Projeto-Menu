using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProjMenu
{
    public partial class TelaLogin : Form
    {
        SqlConnection Conexao = new SqlConnection(@"Data Source=DESKTOP-SIMS6N4\SQLEXPRESS02;Initial Catalog=tbUsuario;Integrated Security=True");

        public TelaLogin()
        {
            InitializeComponent();
            txbLogin.Select();
        }

        private void TelaLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {          
            Conexao.Open(); // Abrir a conexão
            verificar();
            string query = "SELECT * FROM Usuario WHERE Login = '" + txbLogin.Text + "' AND Senha = '" + txbSenha.Text + "'";
            SqlDataAdapter dp = new SqlDataAdapter(query, Conexao);
            DataTable dt = new DataTable();
            dp.Fill(dt);

            try
            {
                if (dt.Rows.Count == 1)
                {
                    Form2 Form = new Form2();
                    this.Hide();
                    Form.Show();
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Usuário ou Senha Inválidas" + erro);
                txbLogin.Text = ""; // Limpa as textbox depois de serem verificadas
                txbSenha.Text = "";
                txbLogin.Select(); // Cursor irá sinalizar a primeira textbox
            }
            Conexao.Close(); // Fechar Conexão
        }

        // Verificação das textbox
        void verificar()
        {
            if (txbLogin.Text == "" && txbSenha.Text == "")
            {
                MessageBox.Show("Preencha os campos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbLogin.Select();
            }
        }

        private void TelaLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms.Count == 0)
            {
                Application.Exit();
            }
            else
            {
                foreach (Form formOpen in Application.OpenForms)
                {
                    if (formOpen is Form1)
                    {
                        formOpen.Show();
                        break;
                    }
                }
            }
        }
    }
}