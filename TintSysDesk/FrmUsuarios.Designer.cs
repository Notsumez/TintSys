namespace TintSysDesk
{
    partial class FrmUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUsuarios));
            this.label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtIdNivel = new System.Windows.Forms.TextBox();
            this.txtNomeNivel = new System.Windows.Forms.TextBox();
            this.txtSiglaNivel = new System.Windows.Forms.TextBox();
            this.btnEditarNivel = new System.Windows.Forms.Button();
            this.btnConsultarNivel = new System.Windows.Forms.Button();
            this.btnInserirNivel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvNiveis = new System.Windows.Forms.DataGridView();
            this.clnIdNivel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnNomeNivel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnSiglaNivel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnDeleteNivel = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.clnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnSenha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnNivel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnAtivo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNiveis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(60, 89);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(18, 13);
            this.label.TabIndex = 0;
            this.label.Text = "ID";
            this.label.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Senha";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(240, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nivel";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(271, 158);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(342, 88);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(50, 17);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Ativo";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(82, 223);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Inserir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(165, 223);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Consultar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(246, 223);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "Editar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(82, 85);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(50, 20);
            this.txtId.TabIndex = 10;
            this.txtId.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(82, 110);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(310, 20);
            this.txtNome.TabIndex = 11;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(82, 133);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(310, 20);
            this.txtEmail.TabIndex = 12;
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(82, 158);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(146, 20);
            this.txtSenha.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(71, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "ID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(55, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Nome";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(56, 97);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Sigla";
            // 
            // txtIdNivel
            // 
            this.txtIdNivel.Location = new System.Drawing.Point(91, 39);
            this.txtIdNivel.Name = "txtIdNivel";
            this.txtIdNivel.Size = new System.Drawing.Size(54, 20);
            this.txtIdNivel.TabIndex = 18;
            // 
            // txtNomeNivel
            // 
            this.txtNomeNivel.Location = new System.Drawing.Point(91, 68);
            this.txtNomeNivel.Name = "txtNomeNivel";
            this.txtNomeNivel.Size = new System.Drawing.Size(173, 20);
            this.txtNomeNivel.TabIndex = 19;
            // 
            // txtSiglaNivel
            // 
            this.txtSiglaNivel.Location = new System.Drawing.Point(91, 94);
            this.txtSiglaNivel.Name = "txtSiglaNivel";
            this.txtSiglaNivel.Size = new System.Drawing.Size(100, 20);
            this.txtSiglaNivel.TabIndex = 20;
            // 
            // btnEditarNivel
            // 
            this.btnEditarNivel.FlatAppearance.BorderSize = 0;
            this.btnEditarNivel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnEditarNivel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarNivel.ForeColor = System.Drawing.Color.Black;
            this.btnEditarNivel.Image = global::TintSysDesk.Properties.Resources.Edit;
            this.btnEditarNivel.Location = new System.Drawing.Point(209, 132);
            this.btnEditarNivel.Name = "btnEditarNivel";
            this.btnEditarNivel.Size = new System.Drawing.Size(66, 54);
            this.btnEditarNivel.TabIndex = 23;
            this.btnEditarNivel.Text = "Editar";
            this.btnEditarNivel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEditarNivel.UseVisualStyleBackColor = true;
            this.btnEditarNivel.Click += new System.EventHandler(this.btnEditarNivel_Click);
            // 
            // btnConsultarNivel
            // 
            this.btnConsultarNivel.FlatAppearance.BorderSize = 0;
            this.btnConsultarNivel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnConsultarNivel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarNivel.ForeColor = System.Drawing.Color.Black;
            this.btnConsultarNivel.Image = global::TintSysDesk.Properties.Resources.Search;
            this.btnConsultarNivel.Location = new System.Drawing.Point(128, 132);
            this.btnConsultarNivel.Name = "btnConsultarNivel";
            this.btnConsultarNivel.Size = new System.Drawing.Size(66, 54);
            this.btnConsultarNivel.TabIndex = 22;
            this.btnConsultarNivel.Text = "Consultar";
            this.btnConsultarNivel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnConsultarNivel.UseVisualStyleBackColor = true;
            this.btnConsultarNivel.Click += new System.EventHandler(this.btnConsultarNivel_Click);
            // 
            // btnInserirNivel
            // 
            this.btnInserirNivel.FlatAppearance.BorderSize = 0;
            this.btnInserirNivel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnInserirNivel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInserirNivel.ForeColor = System.Drawing.Color.Black;
            this.btnInserirNivel.Image = global::TintSysDesk.Properties.Resources.Add;
            this.btnInserirNivel.Location = new System.Drawing.Point(47, 132);
            this.btnInserirNivel.Name = "btnInserirNivel";
            this.btnInserirNivel.Size = new System.Drawing.Size(66, 54);
            this.btnInserirNivel.TabIndex = 21;
            this.btnInserirNivel.Text = "Inserir";
            this.btnInserirNivel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnInserirNivel.UseVisualStyleBackColor = true;
            this.btnInserirNivel.Click += new System.EventHandler(this.btnInserirNivel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEditarNivel);
            this.groupBox1.Controls.Add(this.dgvNiveis);
            this.groupBox1.Controls.Add(this.btnConsultarNivel);
            this.groupBox1.Controls.Add(this.btnInserirNivel);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtSiglaNivel);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtNomeNivel);
            this.groupBox1.Controls.Add(this.txtIdNivel);
            this.groupBox1.Location = new System.Drawing.Point(581, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(320, 309);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Niveis";
            // 
            // dgvNiveis
            // 
            this.dgvNiveis.AllowUserToAddRows = false;
            this.dgvNiveis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNiveis.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnIdNivel,
            this.clnNomeNivel,
            this.clnSiglaNivel,
            this.clnDeleteNivel});
            this.dgvNiveis.Location = new System.Drawing.Point(0, 207);
            this.dgvNiveis.Name = "dgvNiveis";
            this.dgvNiveis.ReadOnly = true;
            this.dgvNiveis.RowHeadersVisible = false;
            this.dgvNiveis.Size = new System.Drawing.Size(320, 102);
            this.dgvNiveis.TabIndex = 0;
            this.dgvNiveis.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // clnIdNivel
            // 
            this.clnIdNivel.Frozen = true;
            this.clnIdNivel.HeaderText = "ID";
            this.clnIdNivel.Name = "clnIdNivel";
            this.clnIdNivel.ReadOnly = true;
            this.clnIdNivel.Width = 40;
            // 
            // clnNomeNivel
            // 
            this.clnNomeNivel.Frozen = true;
            this.clnNomeNivel.HeaderText = "Nome";
            this.clnNomeNivel.Name = "clnNomeNivel";
            this.clnNomeNivel.ReadOnly = true;
            this.clnNomeNivel.Width = 120;
            // 
            // clnSiglaNivel
            // 
            this.clnSiglaNivel.Frozen = true;
            this.clnSiglaNivel.HeaderText = "Sigla";
            this.clnSiglaNivel.Name = "clnSiglaNivel";
            this.clnSiglaNivel.ReadOnly = true;
            this.clnSiglaNivel.Width = 80;
            // 
            // clnDeleteNivel
            // 
            this.clnDeleteNivel.Frozen = true;
            this.clnDeleteNivel.HeaderText = "Ação";
            this.clnDeleteNivel.Name = "clnDeleteNivel";
            this.clnDeleteNivel.ReadOnly = true;
            this.clnDeleteNivel.Text = "Excluir";
            this.clnDeleteNivel.Width = 79;
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AllowUserToAddRows = false;
            this.dgvUsuarios.AllowUserToDeleteRows = false;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnId,
            this.clnNome,
            this.clnEmail,
            this.clnSenha,
            this.clnNivel,
            this.clnAtivo});
            this.dgvUsuarios.Location = new System.Drawing.Point(12, 271);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.ReadOnly = true;
            this.dgvUsuarios.RowHeadersVisible = false;
            this.dgvUsuarios.Size = new System.Drawing.Size(543, 140);
            this.dgvUsuarios.TabIndex = 25;
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
            // 
            // clnEmail
            // 
            this.clnEmail.Frozen = true;
            this.clnEmail.HeaderText = "Email";
            this.clnEmail.Name = "clnEmail";
            this.clnEmail.ReadOnly = true;
            // 
            // clnSenha
            // 
            this.clnSenha.Frozen = true;
            this.clnSenha.HeaderText = "Senha";
            this.clnSenha.Name = "clnSenha";
            this.clnSenha.ReadOnly = true;
            // 
            // clnNivel
            // 
            this.clnNivel.Frozen = true;
            this.clnNivel.HeaderText = "Nivel";
            this.clnNivel.Name = "clnNivel";
            this.clnNivel.ReadOnly = true;
            // 
            // clnAtivo
            // 
            this.clnAtivo.Frozen = true;
            this.clnAtivo.HeaderText = "Ativo";
            this.clnAtivo.Name = "clnAtivo";
            this.clnAtivo.ReadOnly = true;
            this.clnAtivo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clnAtivo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // FrmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 450);
            this.Controls.Add(this.dgvUsuarios);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmUsuarios";
            this.Text = "FrmUsuarios";
            this.Load += new System.EventHandler(this.FrmUsuarios_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNiveis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtIdNivel;
        private System.Windows.Forms.TextBox txtNomeNivel;
        private System.Windows.Forms.TextBox txtSiglaNivel;
        private System.Windows.Forms.Button btnEditarNivel;
        private System.Windows.Forms.Button btnConsultarNivel;
        private System.Windows.Forms.Button btnInserirNivel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvNiveis;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnIdNivel;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnNomeNivel;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnSiglaNivel;
        private System.Windows.Forms.DataGridViewButtonColumn clnDeleteNivel;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnSenha;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnNivel;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clnAtivo;
    }
}