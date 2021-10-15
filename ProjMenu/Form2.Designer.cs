namespace ProjMenu
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoUsuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoUsuárioToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deletarUsuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atualizarUsuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bloquearUsuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoHóspedeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirHóspedeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atualizarHóspedeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exibirTelaDeHóspedesCadastradosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoFuncionárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deletarFuncionárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atualizarFuncionárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.exibirTelaDeFuncionariosCadastradosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(846, 565);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.ajudaToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(846, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoUsuárioToolStripMenuItem,
            this.bloquearUsuárioToolStripMenuItem,
            this.funcionáriosToolStripMenuItem});
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // novoUsuárioToolStripMenuItem
            // 
            this.novoUsuárioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoUsuárioToolStripMenuItem1,
            this.deletarUsuárioToolStripMenuItem,
            this.atualizarUsuárioToolStripMenuItem});
            this.novoUsuárioToolStripMenuItem.Name = "novoUsuárioToolStripMenuItem";
            this.novoUsuárioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.novoUsuárioToolStripMenuItem.Text = "Usuário";
            // 
            // novoUsuárioToolStripMenuItem1
            // 
            this.novoUsuárioToolStripMenuItem1.Name = "novoUsuárioToolStripMenuItem1";
            this.novoUsuárioToolStripMenuItem1.Size = new System.Drawing.Size(163, 22);
            this.novoUsuárioToolStripMenuItem1.Text = "Novo Usuário";
            this.novoUsuárioToolStripMenuItem1.Click += new System.EventHandler(this.novoUsuárioToolStripMenuItem1_Click);
            // 
            // deletarUsuárioToolStripMenuItem
            // 
            this.deletarUsuárioToolStripMenuItem.Name = "deletarUsuárioToolStripMenuItem";
            this.deletarUsuárioToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.deletarUsuárioToolStripMenuItem.Text = "Deletar Usuário";
            this.deletarUsuárioToolStripMenuItem.Click += new System.EventHandler(this.deletarUsuárioToolStripMenuItem_Click);
            // 
            // atualizarUsuárioToolStripMenuItem
            // 
            this.atualizarUsuárioToolStripMenuItem.Name = "atualizarUsuárioToolStripMenuItem";
            this.atualizarUsuárioToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.atualizarUsuárioToolStripMenuItem.Text = "Atualizar Usuário";
            this.atualizarUsuárioToolStripMenuItem.Click += new System.EventHandler(this.atualizarUsuárioToolStripMenuItem_Click);
            // 
            // bloquearUsuárioToolStripMenuItem
            // 
            this.bloquearUsuárioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoHóspedeToolStripMenuItem,
            this.excluirHóspedeToolStripMenuItem,
            this.atualizarHóspedeToolStripMenuItem,
            this.exibirTelaDeHóspedesCadastradosToolStripMenuItem});
            this.bloquearUsuárioToolStripMenuItem.Name = "bloquearUsuárioToolStripMenuItem";
            this.bloquearUsuárioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.bloquearUsuárioToolStripMenuItem.Text = "Hóspede";
            // 
            // novoHóspedeToolStripMenuItem
            // 
            this.novoHóspedeToolStripMenuItem.Name = "novoHóspedeToolStripMenuItem";
            this.novoHóspedeToolStripMenuItem.Size = new System.Drawing.Size(262, 22);
            this.novoHóspedeToolStripMenuItem.Text = "Novo Hóspede";
            this.novoHóspedeToolStripMenuItem.Click += new System.EventHandler(this.novoHospedeToolStripMenuItem_Click);
            // 
            // excluirHóspedeToolStripMenuItem
            // 
            this.excluirHóspedeToolStripMenuItem.Name = "excluirHóspedeToolStripMenuItem";
            this.excluirHóspedeToolStripMenuItem.Size = new System.Drawing.Size(262, 22);
            this.excluirHóspedeToolStripMenuItem.Text = "Deletar Hóspede";
            this.excluirHóspedeToolStripMenuItem.Click += new System.EventHandler(this.DeletarHospedeToolStripMenuItem_Click);
            // 
            // atualizarHóspedeToolStripMenuItem
            // 
            this.atualizarHóspedeToolStripMenuItem.Name = "atualizarHóspedeToolStripMenuItem";
            this.atualizarHóspedeToolStripMenuItem.Size = new System.Drawing.Size(262, 22);
            this.atualizarHóspedeToolStripMenuItem.Text = "Atualizar Hóspede";
            this.atualizarHóspedeToolStripMenuItem.Click += new System.EventHandler(this.atualizarHóspedeToolStripMenuItem_Click);
            // 
            // exibirTelaDeHóspedesCadastradosToolStripMenuItem
            // 
            this.exibirTelaDeHóspedesCadastradosToolStripMenuItem.Name = "exibirTelaDeHóspedesCadastradosToolStripMenuItem";
            this.exibirTelaDeHóspedesCadastradosToolStripMenuItem.Size = new System.Drawing.Size(262, 22);
            this.exibirTelaDeHóspedesCadastradosToolStripMenuItem.Text = "Exibir tela de Hóspedes cadastrados";
            this.exibirTelaDeHóspedesCadastradosToolStripMenuItem.Click += new System.EventHandler(this.exibirTelaDeHóspedesCadastradosToolStripMenuItem_Click);
            // 
            // funcionáriosToolStripMenuItem
            // 
            this.funcionáriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoFuncionárioToolStripMenuItem,
            this.deletarFuncionárioToolStripMenuItem,
            this.atualizarFuncionárioToolStripMenuItem,
            this.exibirTelaDeFuncionariosCadastradosToolStripMenuItem});
            this.funcionáriosToolStripMenuItem.Name = "funcionáriosToolStripMenuItem";
            this.funcionáriosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.funcionáriosToolStripMenuItem.Text = "Funcionário";
            // 
            // novoFuncionárioToolStripMenuItem
            // 
            this.novoFuncionárioToolStripMenuItem.Name = "novoFuncionárioToolStripMenuItem";
            this.novoFuncionárioToolStripMenuItem.Size = new System.Drawing.Size(278, 22);
            this.novoFuncionárioToolStripMenuItem.Text = "Novo Funcionário";
            this.novoFuncionárioToolStripMenuItem.Click += new System.EventHandler(this.novoFuncionárioToolStripMenuItem_Click_1);
            // 
            // deletarFuncionárioToolStripMenuItem
            // 
            this.deletarFuncionárioToolStripMenuItem.Name = "deletarFuncionárioToolStripMenuItem";
            this.deletarFuncionárioToolStripMenuItem.Size = new System.Drawing.Size(278, 22);
            this.deletarFuncionárioToolStripMenuItem.Text = "Deletar Funcionário";
            this.deletarFuncionárioToolStripMenuItem.Click += new System.EventHandler(this.deletarFuncionárioToolStripMenuItem_Click);
            // 
            // atualizarFuncionárioToolStripMenuItem
            // 
            this.atualizarFuncionárioToolStripMenuItem.Name = "atualizarFuncionárioToolStripMenuItem";
            this.atualizarFuncionárioToolStripMenuItem.Size = new System.Drawing.Size(278, 22);
            this.atualizarFuncionárioToolStripMenuItem.Text = "Atualizar Funcionário";
            this.atualizarFuncionárioToolStripMenuItem.Click += new System.EventHandler(this.atualizarFuncionárioToolStripMenuItem_Click);
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            this.ajudaToolStripMenuItem.Click += new System.EventHandler(this.ajudaToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-116, 27);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(994, 565);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // exibirTelaDeFuncionariosCadastradosToolStripMenuItem
            // 
            this.exibirTelaDeFuncionariosCadastradosToolStripMenuItem.Name = "exibirTelaDeFuncionariosCadastradosToolStripMenuItem";
            this.exibirTelaDeFuncionariosCadastradosToolStripMenuItem.Size = new System.Drawing.Size(278, 22);
            this.exibirTelaDeFuncionariosCadastradosToolStripMenuItem.Text = "Exibir tela de Funcionarios cadastrados";
            this.exibirTelaDeFuncionariosCadastradosToolStripMenuItem.Click += new System.EventHandler(this.exibirTelaDeFuncionariosCadastradosToolStripMenuItem_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(846, 589);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "Hotel Oliver";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoUsuárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bloquearUsuárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoUsuárioToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem novoHóspedeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem funcionáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoFuncionárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excluirHóspedeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deletarUsuárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atualizarUsuárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atualizarHóspedeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deletarFuncionárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atualizarFuncionárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exibirTelaDeHóspedesCadastradosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exibirTelaDeFuncionariosCadastradosToolStripMenuItem;
    }
}