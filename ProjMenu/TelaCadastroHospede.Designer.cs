namespace ProjMenu
{
    partial class TelaCadastroHospede
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaCadastroHospede));
            this.lblNome = new System.Windows.Forms.Label();
            this.lblCPF = new System.Windows.Forms.Label();
            this.lblDataCheckIn = new System.Windows.Forms.Label();
            this.lblDataCheckOut = new System.Windows.Forms.Label();
            this.lblNumeroQuarto = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.txtDataCheckIn = new System.Windows.Forms.TextBox();
            this.txtDataCheckOut = new System.Windows.Forms.TextBox();
            this.txtNumeroQuarto = new System.Windows.Forms.TextBox();
            this.btnInserir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(16, 32);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(47, 16);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPF.Location = new System.Drawing.Point(16, 75);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(32, 16);
            this.lblCPF.TabIndex = 1;
            this.lblCPF.Text = "CPF:";
            // 
            // lblDataCheckIn
            // 
            this.lblDataCheckIn.AutoSize = true;
            this.lblDataCheckIn.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataCheckIn.Location = new System.Drawing.Point(16, 119);
            this.lblDataCheckIn.Name = "lblDataCheckIn";
            this.lblDataCheckIn.Size = new System.Drawing.Size(83, 16);
            this.lblDataCheckIn.TabIndex = 2;
            this.lblDataCheckIn.Text = "Data CheckIn";
            // 
            // lblDataCheckOut
            // 
            this.lblDataCheckOut.AutoSize = true;
            this.lblDataCheckOut.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataCheckOut.Location = new System.Drawing.Point(16, 158);
            this.lblDataCheckOut.Name = "lblDataCheckOut";
            this.lblDataCheckOut.Size = new System.Drawing.Size(94, 16);
            this.lblDataCheckOut.TabIndex = 3;
            this.lblDataCheckOut.Text = "Data CheckOut";
            // 
            // lblNumeroQuarto
            // 
            this.lblNumeroQuarto.AutoSize = true;
            this.lblNumeroQuarto.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroQuarto.Location = new System.Drawing.Point(16, 194);
            this.lblNumeroQuarto.Name = "lblNumeroQuarto";
            this.lblNumeroQuarto.Size = new System.Drawing.Size(101, 16);
            this.lblNumeroQuarto.TabIndex = 4;
            this.lblNumeroQuarto.Text = "Número Quarto";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(66, 28);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(190, 20);
            this.txtNome.TabIndex = 5;
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(54, 68);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(190, 20);
            this.txtCPF.TabIndex = 6;
            // 
            // txtDataCheckIn
            // 
            this.txtDataCheckIn.Location = new System.Drawing.Point(105, 115);
            this.txtDataCheckIn.Name = "txtDataCheckIn";
            this.txtDataCheckIn.Size = new System.Drawing.Size(84, 20);
            this.txtDataCheckIn.TabIndex = 7;
            // 
            // txtDataCheckOut
            // 
            this.txtDataCheckOut.Location = new System.Drawing.Point(116, 154);
            this.txtDataCheckOut.Name = "txtDataCheckOut";
            this.txtDataCheckOut.Size = new System.Drawing.Size(85, 20);
            this.txtDataCheckOut.TabIndex = 8;
            // 
            // txtNumeroQuarto
            // 
            this.txtNumeroQuarto.Location = new System.Drawing.Point(123, 190);
            this.txtNumeroQuarto.Name = "txtNumeroQuarto";
            this.txtNumeroQuarto.Size = new System.Drawing.Size(43, 20);
            this.txtNumeroQuarto.TabIndex = 9;
            // 
            // btnInserir
            // 
            this.btnInserir.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnInserir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInserir.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnInserir.Location = new System.Drawing.Point(332, 102);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(111, 45);
            this.btnInserir.TabIndex = 18;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = false;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // TelaCadastroHospede
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(506, 238);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.txtNumeroQuarto);
            this.Controls.Add(this.txtDataCheckOut);
            this.Controls.Add(this.txtDataCheckIn);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNumeroQuarto);
            this.Controls.Add(this.lblDataCheckOut);
            this.Controls.Add(this.lblDataCheckIn);
            this.Controls.Add(this.lblCPF);
            this.Controls.Add(this.lblNome);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TelaCadastroHospede";
            this.Text = "Tela de Cadastro Hóspedes";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TelaCadastroHospede_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Label lblDataCheckIn;
        private System.Windows.Forms.Label lblDataCheckOut;
        private System.Windows.Forms.Label lblNumeroQuarto;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.TextBox txtDataCheckIn;
        private System.Windows.Forms.TextBox txtDataCheckOut;
        private System.Windows.Forms.TextBox txtNumeroQuarto;
        private System.Windows.Forms.Button btnInserir;
    }
}