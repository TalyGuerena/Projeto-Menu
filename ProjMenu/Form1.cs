using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProjMenu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void entrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaLogin Tela = new TelaLogin();
            Tela.Show();

            this.Hide();
        }
    }
}