namespace ProjMenu
{
    partial class DeletarFuncionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeletarFuncionario));
            this.lblInsira = new System.Windows.Forms.Label();
            this.txtDeletar = new System.Windows.Forms.TextBox();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.lblInsiraCpf = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblInsira
            // 
            this.lblInsira.AutoSize = true;
            this.lblInsira.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInsira.Location = new System.Drawing.Point(115, 55);
            this.lblInsira.Name = "lblInsira";
            this.lblInsira.Size = new System.Drawing.Size(0, 23);
            this.lblInsira.TabIndex = 25;
            // 
            // txtDeletar
            // 
            this.txtDeletar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDeletar.Location = new System.Drawing.Point(168, 104);
            this.txtDeletar.Name = "txtDeletar";
            this.txtDeletar.Size = new System.Drawing.Size(113, 26);
            this.txtDeletar.TabIndex = 24;
            // 
            // btnDeletar
            // 
            this.btnDeletar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDeletar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeletar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDeletar.Location = new System.Drawing.Point(153, 145);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(137, 40);
            this.btnDeletar.TabIndex = 23;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = false;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // lblInsiraCpf
            // 
            this.lblInsiraCpf.AutoSize = true;
            this.lblInsiraCpf.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInsiraCpf.Location = new System.Drawing.Point(101, 55);
            this.lblInsiraCpf.Name = "lblInsiraCpf";
            this.lblInsiraCpf.Size = new System.Drawing.Size(232, 23);
            this.lblInsiraCpf.TabIndex = 29;
            this.lblInsiraCpf.Text = "Insira o CPF para deletar:";
            // 
            // DeletarFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(454, 238);
            this.Controls.Add(this.lblInsiraCpf);
            this.Controls.Add(this.lblInsira);
            this.Controls.Add(this.txtDeletar);
            this.Controls.Add(this.btnDeletar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DeletarFuncionario";
            this.Text = "DeletarFuncionario";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DeletarFuncionario_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInsira;
        private System.Windows.Forms.TextBox txtDeletar;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.Label lblInsiraCpf;
    }
}