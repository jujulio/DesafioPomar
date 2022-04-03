namespace Desafio_Pomar
{
    partial class frmGrupoArvore
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
            this.btnFecha = new System.Windows.Forms.Button();
            this.panelFecha = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.bntAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.txtFKArvore = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIDGrupo = new System.Windows.Forms.TextBox();
            this.txtDescGrupo = new System.Windows.Forms.TextBox();
            this.cbbArvore = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGrupo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gridGrupoArvore = new System.Windows.Forms.DataGridView();
            this.btnPesquisa = new System.Windows.Forms.Button();
            this.txtPesqId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panelFecha.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridGrupoArvore)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFecha
            // 
            this.btnFecha.BackColor = System.Drawing.Color.Transparent;
            this.btnFecha.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnFecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFecha.ForeColor = System.Drawing.Color.Red;
            this.btnFecha.Location = new System.Drawing.Point(613, 0);
            this.btnFecha.Name = "btnFecha";
            this.btnFecha.Size = new System.Drawing.Size(45, 22);
            this.btnFecha.TabIndex = 6;
            this.btnFecha.Text = "X";
            this.btnFecha.UseVisualStyleBackColor = false;
            this.btnFecha.Click += new System.EventHandler(this.btnFecha_Click);
            // 
            // panelFecha
            // 
            this.panelFecha.BackColor = System.Drawing.Color.White;
            this.panelFecha.Controls.Add(this.btnFecha);
            this.panelFecha.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFecha.ForeColor = System.Drawing.Color.Transparent;
            this.panelFecha.Location = new System.Drawing.Point(0, 0);
            this.panelFecha.Name = "panelFecha";
            this.panelFecha.Size = new System.Drawing.Size(658, 22);
            this.panelFecha.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSalvar);
            this.groupBox1.Controls.Add(this.bntAlterar);
            this.groupBox1.Controls.Add(this.btnExcluir);
            this.groupBox1.Controls.Add(this.txtFKArvore);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtIDGrupo);
            this.groupBox1.Controls.Add(this.txtDescGrupo);
            this.groupBox1.Controls.Add(this.cbbArvore);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtGrupo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(634, 121);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastrar Grupo de Arvores";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(566, 22);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(62, 23);
            this.btnSalvar.TabIndex = 18;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // bntAlterar
            // 
            this.bntAlterar.Location = new System.Drawing.Point(566, 51);
            this.bntAlterar.Name = "bntAlterar";
            this.bntAlterar.Size = new System.Drawing.Size(62, 23);
            this.bntAlterar.TabIndex = 17;
            this.bntAlterar.Text = "Alterar";
            this.bntAlterar.UseVisualStyleBackColor = true;
            this.bntAlterar.Click += new System.EventHandler(this.bntAlterar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(566, 80);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(62, 23);
            this.btnExcluir.TabIndex = 16;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // txtFKArvore
            // 
            this.txtFKArvore.Enabled = false;
            this.txtFKArvore.Location = new System.Drawing.Point(34, 87);
            this.txtFKArvore.Name = "txtFKArvore";
            this.txtFKArvore.Size = new System.Drawing.Size(49, 20);
            this.txtFKArvore.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "ID:";
            // 
            // txtIDGrupo
            // 
            this.txtIDGrupo.Location = new System.Drawing.Point(34, 27);
            this.txtIDGrupo.Name = "txtIDGrupo";
            this.txtIDGrupo.Size = new System.Drawing.Size(49, 20);
            this.txtIDGrupo.TabIndex = 13;
            // 
            // txtDescGrupo
            // 
            this.txtDescGrupo.Location = new System.Drawing.Point(149, 58);
            this.txtDescGrupo.Name = "txtDescGrupo";
            this.txtDescGrupo.Size = new System.Drawing.Size(390, 20);
            this.txtDescGrupo.TabIndex = 11;
            // 
            // cbbArvore
            // 
            this.cbbArvore.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbArvore.FormattingEnabled = true;
            this.cbbArvore.Location = new System.Drawing.Point(149, 87);
            this.cbbArvore.Name = "cbbArvore";
            this.cbbArvore.Size = new System.Drawing.Size(260, 21);
            this.cbbArvore.TabIndex = 10;
            this.cbbArvore.SelectedIndexChanged += new System.EventHandler(this.cbbArvore_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(102, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Arvore:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Descrição:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nome:";
            // 
            // txtGrupo
            // 
            this.txtGrupo.Location = new System.Drawing.Point(149, 27);
            this.txtGrupo.Name = "txtGrupo";
            this.txtGrupo.Size = new System.Drawing.Size(390, 20);
            this.txtGrupo.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // gridGrupoArvore
            // 
            this.gridGrupoArvore.AllowUserToAddRows = false;
            this.gridGrupoArvore.AllowUserToDeleteRows = false;
            this.gridGrupoArvore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridGrupoArvore.Location = new System.Drawing.Point(12, 197);
            this.gridGrupoArvore.Name = "gridGrupoArvore";
            this.gridGrupoArvore.ReadOnly = true;
            this.gridGrupoArvore.Size = new System.Drawing.Size(634, 183);
            this.gridGrupoArvore.TabIndex = 14;
            this.gridGrupoArvore.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridGrupoArvore_CellClick);
            this.gridGrupoArvore.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridGrupoArvore_CellContentClick);
            // 
            // btnPesquisa
            // 
            this.btnPesquisa.Location = new System.Drawing.Point(110, 168);
            this.btnPesquisa.Name = "btnPesquisa";
            this.btnPesquisa.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisa.TabIndex = 12;
            this.btnPesquisa.Text = "Pesquisa";
            this.btnPesquisa.UseVisualStyleBackColor = true;
            this.btnPesquisa.Click += new System.EventHandler(this.btnPesquisa_Click);
            // 
            // txtPesqId
            // 
            this.txtPesqId.Location = new System.Drawing.Point(39, 170);
            this.txtPesqId.Name = "txtPesqId";
            this.txtPesqId.Size = new System.Drawing.Size(65, 20);
            this.txtPesqId.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "ID:";
            // 
            // frmGrupoArvore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 420);
            this.ControlBox = false;
            this.Controls.Add(this.txtPesqId);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gridGrupoArvore);
            this.Controls.Add(this.btnPesquisa);
            this.Controls.Add(this.panelFecha);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(658, 420);
            this.MinimumSize = new System.Drawing.Size(658, 420);
            this.Name = "frmGrupoArvore";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmGrupoArvore";
            this.Load += new System.EventHandler(this.frmGrupoArvore_Load);
            this.panelFecha.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridGrupoArvore)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFecha;
        private System.Windows.Forms.Panel panelFecha;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDescGrupo;
        private System.Windows.Forms.ComboBox cbbArvore;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGrupo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gridGrupoArvore;
        private System.Windows.Forms.Button btnPesquisa;
        private System.Windows.Forms.TextBox txtFKArvore;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIDGrupo;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button bntAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.TextBox txtPesqId;
        private System.Windows.Forms.Label label6;
    }
}