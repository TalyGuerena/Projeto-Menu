namespace ProjMenu
{
    partial class funcionariosCadastrados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(funcionariosCadastrados));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnSelect2 = new System.Windows.Forms.Button();
            this.lblTodos = new System.Windows.Forms.Label();
            this.lblFerias = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvDados);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(548, 334);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select";
            // 
            // dgvDados
            // 
            this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDados.Location = new System.Drawing.Point(6, 19);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.Size = new System.Drawing.Size(536, 309);
            this.dgvDados.TabIndex = 0;
            // 
            // btnSelect
            // 
            this.btnSelect.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelect.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSelect.Location = new System.Drawing.Point(123, 352);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(97, 33);
            this.btnSelect.TabIndex = 22;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnSelect2
            // 
            this.btnSelect2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSelect2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelect2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSelect2.Location = new System.Drawing.Point(363, 352);
            this.btnSelect2.Name = "btnSelect2";
            this.btnSelect2.Size = new System.Drawing.Size(97, 33);
            this.btnSelect2.TabIndex = 23;
            this.btnSelect2.Text = "Select";
            this.btnSelect2.UseVisualStyleBackColor = false;
            this.btnSelect2.Click += new System.EventHandler(this.btnSelect2_Click);
            // 
            // lblTodos
            // 
            this.lblTodos.AutoSize = true;
            this.lblTodos.Location = new System.Drawing.Point(120, 391);
            this.lblTodos.Name = "lblTodos";
            this.lblTodos.Size = new System.Drawing.Size(111, 13);
            this.lblTodos.TabIndex = 24;
            this.lblTodos.Text = "Todos os funcionários";
            // 
            // lblFerias
            // 
            this.lblFerias.AutoSize = true;
            this.lblFerias.Location = new System.Drawing.Point(334, 391);
            this.lblFerias.Name = "lblFerias";
            this.lblFerias.Size = new System.Drawing.Size(160, 13);
            this.lblFerias.TabIndex = 25;
            this.lblFerias.Text = "Funcionários que estão de férias";
            // 
            // funcionariosCadastrados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(572, 413);
            this.Controls.Add(this.lblFerias);
            this.Controls.Add(this.lblTodos);
            this.Controls.Add(this.btnSelect2);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "funcionariosCadastrados";
            this.Text = "funcionariosCadastrados";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.funcionariosCadastrados_FormClosed);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.DataGridView dgvDados;
        private System.Windows.Forms.Button btnSelect2;
        private System.Windows.Forms.Label lblTodos;
        private System.Windows.Forms.Label lblFerias;
    }
}