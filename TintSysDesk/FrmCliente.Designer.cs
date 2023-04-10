namespace TintSysDesk
{
    partial class FrmCliente
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabCliente = new System.Windows.Forms.TabPage();
            this.tabTelefone = new System.Windows.Forms.TabPage();
            this.tabEndereco = new System.Windows.Forms.TabPage();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtDateTime = new System.Windows.Forms.TextBox();
            this.txtAtivo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabCliente);
            this.tabControl1.Controls.Add(this.tabTelefone);
            this.tabControl1.Controls.Add(this.tabEndereco);
            this.tabControl1.Location = new System.Drawing.Point(133, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(737, 487);
            this.tabControl1.TabIndex = 0;
            // 
            // tabCliente
            // 
            this.tabCliente.Controls.Add(this.label1);
            this.tabCliente.Controls.Add(this.txtAtivo);
            this.tabCliente.Controls.Add(this.txtDateTime);
            this.tabCliente.Controls.Add(this.txtEmail);
            this.tabCliente.Controls.Add(this.txtCpf);
            this.tabCliente.Controls.Add(this.txtNome);
            this.tabCliente.Controls.Add(this.txtId);
            this.tabCliente.Location = new System.Drawing.Point(4, 22);
            this.tabCliente.Name = "tabCliente";
            this.tabCliente.Padding = new System.Windows.Forms.Padding(3);
            this.tabCliente.Size = new System.Drawing.Size(729, 461);
            this.tabCliente.TabIndex = 0;
            this.tabCliente.Text = "Clientes";
            this.tabCliente.UseVisualStyleBackColor = true;
            // 
            // tabTelefone
            // 
            this.tabTelefone.Location = new System.Drawing.Point(4, 22);
            this.tabTelefone.Name = "tabTelefone";
            this.tabTelefone.Padding = new System.Windows.Forms.Padding(3);
            this.tabTelefone.Size = new System.Drawing.Size(580, 389);
            this.tabTelefone.TabIndex = 1;
            this.tabTelefone.Text = "Telefone";
            this.tabTelefone.UseVisualStyleBackColor = true;
            // 
            // tabEndereco
            // 
            this.tabEndereco.Location = new System.Drawing.Point(4, 22);
            this.tabEndereco.Name = "tabEndereco";
            this.tabEndereco.Size = new System.Drawing.Size(580, 389);
            this.tabEndereco.TabIndex = 2;
            this.tabEndereco.Text = "Endereço";
            this.tabEndereco.UseVisualStyleBackColor = true;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(228, 71);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(235, 20);
            this.txtId.TabIndex = 0;
            this.txtId.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(228, 97);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(235, 20);
            this.txtNome.TabIndex = 1;
            this.txtNome.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(228, 123);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(235, 20);
            this.txtCpf.TabIndex = 2;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(228, 149);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(235, 20);
            this.txtEmail.TabIndex = 3;
            // 
            // txtDateTime
            // 
            this.txtDateTime.Location = new System.Drawing.Point(228, 175);
            this.txtDateTime.Name = "txtDateTime";
            this.txtDateTime.Size = new System.Drawing.Size(235, 20);
            this.txtDateTime.TabIndex = 4;
            // 
            // txtAtivo
            // 
            this.txtAtivo.Location = new System.Drawing.Point(228, 201);
            this.txtAtivo.Name = "txtAtivo";
            this.txtAtivo.Size = new System.Drawing.Size(235, 20);
            this.txtAtivo.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(236, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "CADASTRO DE CLIENTES";
            // 
            // FrmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 539);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmCliente";
            this.Text = "FrmCliente";
            this.Load += new System.EventHandler(this.FrmCliente_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabCliente.ResumeLayout(false);
            this.tabCliente.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabCliente;
        private System.Windows.Forms.TabPage tabTelefone;
        private System.Windows.Forms.TabPage tabEndereco;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtAtivo;
        private System.Windows.Forms.TextBox txtDateTime;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtCpf;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label1;
    }
}