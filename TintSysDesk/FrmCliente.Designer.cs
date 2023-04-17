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
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnInserir = new System.Windows.Forms.Button();
            this.dgvCliente = new System.Windows.Forms.DataGridView();
            this.clnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnCpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnDatacad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnAtivo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.chkAtivo = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDatacad = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.tabTelefone = new System.Windows.Forms.TabPage();
            this.tabEndereco = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbClienteTel = new System.Windows.Forms.ComboBox();
            this.txtIdTel = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNumTel = new System.Windows.Forms.TextBox();
            this.txtTipoTel = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnEditarTel = new System.Windows.Forms.Button();
            this.btnConsultarTel = new System.Windows.Forms.Button();
            this.btnInserirTel = new System.Windows.Forms.Button();
            this.dgvTelefone = new System.Windows.Forms.DataGridView();
            this.clnIdTel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnNumTel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnTipoTel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnClienteTel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).BeginInit();
            this.tabTelefone.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTelefone)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabCliente);
            this.tabControl1.Controls.Add(this.tabTelefone);
            this.tabControl1.Controls.Add(this.tabEndereco);
            this.tabControl1.Location = new System.Drawing.Point(54, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(903, 622);
            this.tabControl1.TabIndex = 0;
            // 
            // tabCliente
            // 
            this.tabCliente.Controls.Add(this.btnEditar);
            this.tabCliente.Controls.Add(this.btnConsultar);
            this.tabCliente.Controls.Add(this.btnInserir);
            this.tabCliente.Controls.Add(this.dgvCliente);
            this.tabCliente.Controls.Add(this.chkAtivo);
            this.tabCliente.Controls.Add(this.label6);
            this.tabCliente.Controls.Add(this.label5);
            this.tabCliente.Controls.Add(this.label4);
            this.tabCliente.Controls.Add(this.label3);
            this.tabCliente.Controls.Add(this.label2);
            this.tabCliente.Controls.Add(this.label1);
            this.tabCliente.Controls.Add(this.txtDatacad);
            this.tabCliente.Controls.Add(this.txtEmail);
            this.tabCliente.Controls.Add(this.txtCpf);
            this.tabCliente.Controls.Add(this.txtNome);
            this.tabCliente.Controls.Add(this.txtId);
            this.tabCliente.Location = new System.Drawing.Point(4, 22);
            this.tabCliente.Name = "tabCliente";
            this.tabCliente.Padding = new System.Windows.Forms.Padding(3);
            this.tabCliente.Size = new System.Drawing.Size(895, 596);
            this.tabCliente.TabIndex = 0;
            this.tabCliente.Text = "Clientes";
            this.tabCliente.UseVisualStyleBackColor = true;
            this.tabCliente.Click += new System.EventHandler(this.tabCliente_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(617, 248);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 16;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(422, 248);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 23);
            this.btnConsultar.TabIndex = 15;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(235, 248);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(75, 23);
            this.btnInserir.TabIndex = 14;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // dgvCliente
            // 
            this.dgvCliente.AllowUserToAddRows = false;
            this.dgvCliente.AllowUserToDeleteRows = false;
            this.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnId,
            this.clnNome,
            this.clnCpf,
            this.clnEmail,
            this.clnDatacad,
            this.clnAtivo});
            this.dgvCliente.Location = new System.Drawing.Point(96, 287);
            this.dgvCliente.Name = "dgvCliente";
            this.dgvCliente.ReadOnly = true;
            this.dgvCliente.RowHeadersVisible = false;
            this.dgvCliente.Size = new System.Drawing.Size(717, 279);
            this.dgvCliente.TabIndex = 13;
            // 
            // clnId
            // 
            this.clnId.Frozen = true;
            this.clnId.HeaderText = "ID";
            this.clnId.Name = "clnId";
            this.clnId.ReadOnly = true;
            this.clnId.Width = 40;
            // 
            // clnNome
            // 
            this.clnNome.Frozen = true;
            this.clnNome.HeaderText = "Nome";
            this.clnNome.Name = "clnNome";
            this.clnNome.ReadOnly = true;
            this.clnNome.Width = 190;
            // 
            // clnCpf
            // 
            this.clnCpf.Frozen = true;
            this.clnCpf.HeaderText = "CPF";
            this.clnCpf.Name = "clnCpf";
            this.clnCpf.ReadOnly = true;
            this.clnCpf.Width = 120;
            // 
            // clnEmail
            // 
            this.clnEmail.Frozen = true;
            this.clnEmail.HeaderText = "Email";
            this.clnEmail.Name = "clnEmail";
            this.clnEmail.ReadOnly = true;
            this.clnEmail.Width = 170;
            // 
            // clnDatacad
            // 
            this.clnDatacad.Frozen = true;
            this.clnDatacad.HeaderText = "Data de Cadastro";
            this.clnDatacad.Name = "clnDatacad";
            this.clnDatacad.ReadOnly = true;
            // 
            // clnAtivo
            // 
            this.clnAtivo.Frozen = true;
            this.clnAtivo.HeaderText = "Ativo";
            this.clnAtivo.Name = "clnAtivo";
            this.clnAtivo.ReadOnly = true;
            // 
            // chkAtivo
            // 
            this.chkAtivo.AutoSize = true;
            this.chkAtivo.Location = new System.Drawing.Point(518, 63);
            this.chkAtivo.Name = "chkAtivo";
            this.chkAtivo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkAtivo.Size = new System.Drawing.Size(50, 17);
            this.chkAtivo.TabIndex = 12;
            this.chkAtivo.Text = "Ativo";
            this.chkAtivo.UseVisualStyleBackColor = true;
            this.chkAtivo.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(394, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Data de Cadastro do Cliente";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(426, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Email do Cliente";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(426, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "CPF do Cliente";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(419, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Nome do Cliente";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(426, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Id do Cliente";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(361, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "CADASTRO DE CLIENTES";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtDatacad
            // 
            this.txtDatacad.Location = new System.Drawing.Point(345, 209);
            this.txtDatacad.Name = "txtDatacad";
            this.txtDatacad.Size = new System.Drawing.Size(223, 20);
            this.txtDatacad.TabIndex = 4;
            this.txtDatacad.TextChanged += new System.EventHandler(this.txtDateTime_TextChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(345, 172);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(223, 20);
            this.txtEmail.TabIndex = 3;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(345, 136);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(223, 20);
            this.txtCpf.TabIndex = 2;
            this.txtCpf.TextChanged += new System.EventHandler(this.txtCpf_TextChanged);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(345, 99);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(223, 20);
            this.txtNome.TabIndex = 1;
            this.txtNome.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(345, 60);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(169, 20);
            this.txtId.TabIndex = 0;
            this.txtId.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tabTelefone
            // 
            this.tabTelefone.Controls.Add(this.dgvTelefone);
            this.tabTelefone.Controls.Add(this.btnEditarTel);
            this.tabTelefone.Controls.Add(this.btnConsultarTel);
            this.tabTelefone.Controls.Add(this.btnInserirTel);
            this.tabTelefone.Controls.Add(this.label11);
            this.tabTelefone.Controls.Add(this.txtTipoTel);
            this.tabTelefone.Controls.Add(this.txtNumTel);
            this.tabTelefone.Controls.Add(this.label9);
            this.tabTelefone.Controls.Add(this.txtIdTel);
            this.tabTelefone.Controls.Add(this.cmbClienteTel);
            this.tabTelefone.Controls.Add(this.label10);
            this.tabTelefone.Controls.Add(this.label8);
            this.tabTelefone.Controls.Add(this.label7);
            this.tabTelefone.Location = new System.Drawing.Point(4, 22);
            this.tabTelefone.Name = "tabTelefone";
            this.tabTelefone.Padding = new System.Windows.Forms.Padding(3);
            this.tabTelefone.Size = new System.Drawing.Size(895, 596);
            this.tabTelefone.TabIndex = 1;
            this.tabTelefone.Text = "Telefone";
            this.tabTelefone.UseVisualStyleBackColor = true;
            this.tabTelefone.Click += new System.EventHandler(this.tabTelefone_Click);
            // 
            // tabEndereco
            // 
            this.tabEndereco.Location = new System.Drawing.Point(4, 22);
            this.tabEndereco.Name = "tabEndereco";
            this.tabEndereco.Size = new System.Drawing.Size(895, 596);
            this.tabEndereco.TabIndex = 2;
            this.tabEndereco.Text = "Endereço";
            this.tabEndereco.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(392, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Id do Telefone";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(388, 114);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Numero do Telefone";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(388, 158);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Tipo de Telefone";
            // 
            // cmbClienteTel
            // 
            this.cmbClienteTel.FormattingEnabled = true;
            this.cmbClienteTel.Location = new System.Drawing.Point(355, 227);
            this.cmbClienteTel.Name = "cmbClienteTel";
            this.cmbClienteTel.Size = new System.Drawing.Size(147, 21);
            this.cmbClienteTel.TabIndex = 4;
            // 
            // txtIdTel
            // 
            this.txtIdTel.Location = new System.Drawing.Point(355, 86);
            this.txtIdTel.Name = "txtIdTel";
            this.txtIdTel.Size = new System.Drawing.Size(147, 20);
            this.txtIdTel.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(330, 37);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(213, 20);
            this.label9.TabIndex = 6;
            this.label9.Text = "CADASTRO DE TELEFONE";
            // 
            // txtNumTel
            // 
            this.txtNumTel.Location = new System.Drawing.Point(355, 130);
            this.txtNumTel.Name = "txtNumTel";
            this.txtNumTel.Size = new System.Drawing.Size(147, 20);
            this.txtNumTel.TabIndex = 7;
            // 
            // txtTipoTel
            // 
            this.txtTipoTel.Location = new System.Drawing.Point(355, 183);
            this.txtTipoTel.Name = "txtTipoTel";
            this.txtTipoTel.Size = new System.Drawing.Size(147, 20);
            this.txtTipoTel.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(401, 211);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 13);
            this.label11.TabIndex = 9;
            this.label11.Text = "Cliente";
            // 
            // btnEditarTel
            // 
            this.btnEditarTel.Location = new System.Drawing.Point(596, 275);
            this.btnEditarTel.Name = "btnEditarTel";
            this.btnEditarTel.Size = new System.Drawing.Size(75, 23);
            this.btnEditarTel.TabIndex = 19;
            this.btnEditarTel.Text = "Editar";
            this.btnEditarTel.UseVisualStyleBackColor = true;
            this.btnEditarTel.Click += new System.EventHandler(this.btnEditarTel_Click);
            // 
            // btnConsultarTel
            // 
            this.btnConsultarTel.Location = new System.Drawing.Point(401, 275);
            this.btnConsultarTel.Name = "btnConsultarTel";
            this.btnConsultarTel.Size = new System.Drawing.Size(75, 23);
            this.btnConsultarTel.TabIndex = 18;
            this.btnConsultarTel.Text = "Consultar";
            this.btnConsultarTel.UseVisualStyleBackColor = true;
            this.btnConsultarTel.Click += new System.EventHandler(this.btnConsultarTel_Click);
            // 
            // btnInserirTel
            // 
            this.btnInserirTel.Location = new System.Drawing.Point(214, 275);
            this.btnInserirTel.Name = "btnInserirTel";
            this.btnInserirTel.Size = new System.Drawing.Size(75, 23);
            this.btnInserirTel.TabIndex = 17;
            this.btnInserirTel.Text = "Inserir";
            this.btnInserirTel.UseVisualStyleBackColor = true;
            this.btnInserirTel.Click += new System.EventHandler(this.btnInserirTel_Click);
            // 
            // dgvTelefone
            // 
            this.dgvTelefone.AllowUserToAddRows = false;
            this.dgvTelefone.AllowUserToDeleteRows = false;
            this.dgvTelefone.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTelefone.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnIdTel,
            this.clnNumTel,
            this.clnTipoTel,
            this.clnClienteTel});
            this.dgvTelefone.Location = new System.Drawing.Point(251, 325);
            this.dgvTelefone.Name = "dgvTelefone";
            this.dgvTelefone.ReadOnly = true;
            this.dgvTelefone.RowHeadersVisible = false;
            this.dgvTelefone.Size = new System.Drawing.Size(403, 211);
            this.dgvTelefone.TabIndex = 20;
            // 
            // clnIdTel
            // 
            this.clnIdTel.Frozen = true;
            this.clnIdTel.HeaderText = "ID";
            this.clnIdTel.Name = "clnIdTel";
            this.clnIdTel.ReadOnly = true;
            this.clnIdTel.Width = 40;
            // 
            // clnNumTel
            // 
            this.clnNumTel.Frozen = true;
            this.clnNumTel.HeaderText = "Numero";
            this.clnNumTel.Name = "clnNumTel";
            this.clnNumTel.ReadOnly = true;
            this.clnNumTel.Width = 130;
            // 
            // clnTipoTel
            // 
            this.clnTipoTel.Frozen = true;
            this.clnTipoTel.HeaderText = "Tipo";
            this.clnTipoTel.Name = "clnTipoTel";
            this.clnTipoTel.ReadOnly = true;
            // 
            // clnClienteTel
            // 
            this.clnClienteTel.Frozen = true;
            this.clnClienteTel.HeaderText = "Cliente";
            this.clnClienteTel.Name = "clnClienteTel";
            this.clnClienteTel.ReadOnly = true;
            this.clnClienteTel.Width = 130;
            // 
            // FrmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 646);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmCliente";
            this.Text = "FrmCliente";
            this.Load += new System.EventHandler(this.FrmCliente_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabCliente.ResumeLayout(false);
            this.tabCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).EndInit();
            this.tabTelefone.ResumeLayout(false);
            this.tabTelefone.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTelefone)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabCliente;
        private System.Windows.Forms.TabPage tabTelefone;
        private System.Windows.Forms.TabPage tabEndereco;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtDatacad;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtCpf;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chkAtivo;
        private System.Windows.Forms.DataGridView dgvCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnDatacad;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clnAtivo;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtIdTel;
        private System.Windows.Forms.ComboBox cmbClienteTel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtTipoTel;
        private System.Windows.Forms.TextBox txtNumTel;
        private System.Windows.Forms.Button btnEditarTel;
        private System.Windows.Forms.Button btnConsultarTel;
        private System.Windows.Forms.Button btnInserirTel;
        private System.Windows.Forms.DataGridView dgvTelefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnIdTel;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnNumTel;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnTipoTel;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnClienteTel;
    }
}