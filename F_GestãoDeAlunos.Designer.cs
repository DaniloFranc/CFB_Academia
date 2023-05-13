namespace CFB_Academia
{
    partial class F_GestãoDeAlunos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_GestãoDeAlunos));
            this.dgv_alunos = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.btn_salvarEdicoes = new System.Windows.Forms.Button();
            this.btn_financeiro = new System.Windows.Forms.Button();
            this.tb_nome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mtb_telefone = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_status = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_turmas = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pb_foto = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_alunos)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_foto)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_alunos
            // 
            this.dgv_alunos.AllowUserToAddRows = false;
            this.dgv_alunos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_alunos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_alunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_alunos.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_alunos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_alunos.EnableHeadersVisualStyles = false;
            this.dgv_alunos.Location = new System.Drawing.Point(12, 12);
            this.dgv_alunos.MultiSelect = false;
            this.dgv_alunos.Name = "dgv_alunos";
            this.dgv_alunos.ReadOnly = true;
            this.dgv_alunos.RowHeadersVisible = false;
            this.dgv_alunos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_alunos.Size = new System.Drawing.Size(364, 402);
            this.dgv_alunos.TabIndex = 2;
            this.dgv_alunos.SelectionChanged += new System.EventHandler(this.dgv_alunos_SelectionChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_fechar);
            this.panel1.Controls.Add(this.btn_excluir);
            this.panel1.Controls.Add(this.btn_salvarEdicoes);
            this.panel1.Controls.Add(this.btn_financeiro);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 420);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(656, 30);
            this.panel1.TabIndex = 9;
            // 
            // btn_fechar
            // 
            this.btn_fechar.Location = new System.Drawing.Point(504, 4);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(149, 23);
            this.btn_fechar.TabIndex = 12;
            this.btn_fechar.Text = "Fechar";
            this.btn_fechar.UseVisualStyleBackColor = true;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // btn_excluir
            // 
            this.btn_excluir.Location = new System.Drawing.Point(337, 4);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(161, 23);
            this.btn_excluir.TabIndex = 10;
            this.btn_excluir.Text = "Excluir Aluno";
            this.btn_excluir.UseVisualStyleBackColor = true;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // btn_salvarEdicoes
            // 
            this.btn_salvarEdicoes.Location = new System.Drawing.Point(3, 4);
            this.btn_salvarEdicoes.Name = "btn_salvarEdicoes";
            this.btn_salvarEdicoes.Size = new System.Drawing.Size(161, 23);
            this.btn_salvarEdicoes.TabIndex = 9;
            this.btn_salvarEdicoes.Text = "Salvar Edições";
            this.btn_salvarEdicoes.UseVisualStyleBackColor = true;
            this.btn_salvarEdicoes.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // btn_financeiro
            // 
            this.btn_financeiro.Location = new System.Drawing.Point(170, 4);
            this.btn_financeiro.Name = "btn_financeiro";
            this.btn_financeiro.Size = new System.Drawing.Size(161, 23);
            this.btn_financeiro.TabIndex = 11;
            this.btn_financeiro.Text = "Financeiro";
            this.btn_financeiro.UseVisualStyleBackColor = true;
            // 
            // tb_nome
            // 
            this.tb_nome.Location = new System.Drawing.Point(385, 28);
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.Size = new System.Drawing.Size(258, 20);
            this.tb_nome.TabIndex = 11;
            this.tb_nome.TextChanged += new System.EventHandler(this.tb_nome_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(382, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nome";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // mtb_telefone
            // 
            this.mtb_telefone.Location = new System.Drawing.Point(385, 74);
            this.mtb_telefone.Mask = "(00)00000-0000";
            this.mtb_telefone.Name = "mtb_telefone";
            this.mtb_telefone.Size = new System.Drawing.Size(127, 20);
            this.mtb_telefone.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(382, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Telefone";
            // 
            // cb_status
            // 
            this.cb_status.FormattingEnabled = true;
            this.cb_status.Location = new System.Drawing.Point(518, 74);
            this.cb_status.Name = "cb_status";
            this.cb_status.Size = new System.Drawing.Size(125, 21);
            this.cb_status.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(515, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Status";
            // 
            // cb_turmas
            // 
            this.cb_turmas.FormattingEnabled = true;
            this.cb_turmas.Location = new System.Drawing.Point(385, 143);
            this.cb_turmas.Name = "cb_turmas";
            this.cb_turmas.Size = new System.Drawing.Size(258, 21);
            this.cb_turmas.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(382, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Turmas";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(382, 201);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(261, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Imprimir Carteirinha";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pb_foto
            // 
            this.pb_foto.Location = new System.Drawing.Point(385, 230);
            this.pb_foto.Name = "pb_foto";
            this.pb_foto.Size = new System.Drawing.Size(100, 139);
            this.pb_foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_foto.TabIndex = 19;
            this.pb_foto.TabStop = false;
            this.pb_foto.Click += new System.EventHandler(this.pb_foto_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(382, 372);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Clique duplo para alterar foto";
            // 
            // F_GestãoDeAlunos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pb_foto);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cb_turmas);
            this.Controls.Add(this.cb_status);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.mtb_telefone);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_nome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgv_alunos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "F_GestãoDeAlunos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.F_GestãoDeAlunos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_alunos)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_foto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_alunos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Button btn_salvarEdicoes;
        private System.Windows.Forms.Button btn_financeiro;
        private System.Windows.Forms.TextBox tb_nome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mtb_telefone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_status;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_turmas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pb_foto;
        private System.Windows.Forms.Label label3;
    }
}