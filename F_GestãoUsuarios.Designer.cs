﻿namespace CFB_Academia
{
    partial class F_GestãoUsuarios
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_GestãoUsuarios));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.btn_novo = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.n_nivel = new System.Windows.Forms.NumericUpDown();
            this.cb_status = new System.Windows.Forms.ComboBox();
            this.tb_senha = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_nome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dgv_usuarios = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.n_nivel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_usuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_fechar);
            this.panel1.Controls.Add(this.btn_excluir);
            this.panel1.Controls.Add(this.btn_salvar);
            this.panel1.Controls.Add(this.btn_novo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 273);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(659, 35);
            this.panel1.TabIndex = 27;
            // 
            // btn_fechar
            // 
            this.btn_fechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_fechar.Location = new System.Drawing.Point(495, 3);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(158, 23);
            this.btn_fechar.TabIndex = 3;
            this.btn_fechar.Text = "Fechar janela";
            this.btn_fechar.UseVisualStyleBackColor = true;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // btn_excluir
            // 
            this.btn_excluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_excluir.Location = new System.Drawing.Point(331, 3);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(158, 23);
            this.btn_excluir.TabIndex = 2;
            this.btn_excluir.Text = "Excluir usuário";
            this.btn_excluir.UseVisualStyleBackColor = true;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // btn_salvar
            // 
            this.btn_salvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_salvar.Location = new System.Drawing.Point(167, 3);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(158, 23);
            this.btn_salvar.TabIndex = 1;
            this.btn_salvar.Text = "Salvar alterações";
            this.btn_salvar.UseVisualStyleBackColor = true;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // btn_novo
            // 
            this.btn_novo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_novo.Location = new System.Drawing.Point(3, 3);
            this.btn_novo.Name = "btn_novo";
            this.btn_novo.Size = new System.Drawing.Size(158, 23);
            this.btn_novo.TabIndex = 0;
            this.btn_novo.Text = "Novo usuário";
            this.btn_novo.UseVisualStyleBackColor = true;
            this.btn_novo.Click += new System.EventHandler(this.btn_novo_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(151, 237);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "D = Desligado";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(68, 237);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "B = Bloqueado";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "A = Ativo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(146, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Nível";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Status";
            // 
            // n_nivel
            // 
            this.n_nivel.Location = new System.Drawing.Point(149, 191);
            this.n_nivel.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.n_nivel.Name = "n_nivel";
            this.n_nivel.Size = new System.Drawing.Size(131, 20);
            this.n_nivel.TabIndex = 21;
            // 
            // cb_status
            // 
            this.cb_status.FormattingEnabled = true;
            this.cb_status.Items.AddRange(new object[] {
            "A",
            "B",
            "D"});
            this.cb_status.Location = new System.Drawing.Point(12, 191);
            this.cb_status.Name = "cb_status";
            this.cb_status.Size = new System.Drawing.Size(131, 21);
            this.cb_status.TabIndex = 20;
            // 
            // tb_senha
            // 
            this.tb_senha.Location = new System.Drawing.Point(149, 140);
            this.tb_senha.Name = "tb_senha";
            this.tb_senha.PasswordChar = '*';
            this.tb_senha.Size = new System.Drawing.Size(131, 20);
            this.tb_senha.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(146, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Senha";
            // 
            // tb_username
            // 
            this.tb_username.Location = new System.Drawing.Point(12, 140);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(131, 20);
            this.tb_username.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Username";
            // 
            // tb_nome
            // 
            this.tb_nome.Location = new System.Drawing.Point(12, 91);
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.Size = new System.Drawing.Size(268, 20);
            this.tb_nome.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Nome";
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(12, 37);
            this.tb_id.Name = "tb_id";
            this.tb_id.ReadOnly = true;
            this.tb_id.Size = new System.Drawing.Size(131, 20);
            this.tb_id.TabIndex = 29;
            this.tb_id.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(18, 13);
            this.label9.TabIndex = 28;
            this.label9.Text = "ID";
            // 
            // dgv_usuarios
            // 
            this.dgv_usuarios.AllowUserToAddRows = false;
            this.dgv_usuarios.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_usuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_usuarios.EnableHeadersVisualStyles = false;
            this.dgv_usuarios.Location = new System.Drawing.Point(299, 12);
            this.dgv_usuarios.MultiSelect = false;
            this.dgv_usuarios.Name = "dgv_usuarios";
            this.dgv_usuarios.ReadOnly = true;
            this.dgv_usuarios.RowHeadersVisible = false;
            this.dgv_usuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_usuarios.Size = new System.Drawing.Size(348, 253);
            this.dgv_usuarios.TabIndex = 30;
            this.dgv_usuarios.SelectionChanged += new System.EventHandler(this.dgv_usuarios_SelectionChanged);
            // 
            // F_GestãoUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 308);
            this.Controls.Add(this.dgv_usuarios);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.n_nivel);
            this.Controls.Add(this.cb_status);
            this.Controls.Add(this.tb_senha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_username);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_nome);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_GestãoUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestão usuarios";
            this.Load += new System.EventHandler(this.F_GestãoUsuarios_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.n_nivel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_usuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown n_nivel;
        private System.Windows.Forms.ComboBox cb_status;
        private System.Windows.Forms.TextBox tb_senha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_nome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgv_usuarios;
        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.Button btn_novo;
    }
}