namespace Desafio_Pomar
{
    partial class frmColheita
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
            this.txtFKArvore = new System.Windows.Forms.TextBox();
            this.txtIDColheita = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.bntAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.txtDataColheita = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblFKArvore = new System.Windows.Forms.Label();
            this.cbbArvore = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtInformacao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gridColheita = new System.Windows.Forms.DataGridView();
            this.btnPesquisa = new System.Windows.Forms.Button();
            this.txtPesqID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panelFecha.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridColheita)).BeginInit();
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
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtFKArvore);
            this.groupBox1.Controls.Add(this.txtIDColheita);
            this.groupBox1.Controls.Add(this.btnSalvar);
            this.groupBox1.Controls.Add(this.bntAlterar);
            this.groupBox1.Controls.Add(this.btnExcluir);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtPeso);
            this.groupBox1.Controls.Add(this.txtDataColheita);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblFKArvore);
            this.groupBox1.Controls.Add(this.cbbArvore);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtInformacao);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(634, 121);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastrar Colheita";
            // 
            // txtFKArvore
            // 
            this.txtFKArvore.Enabled = false;
            this.txtFKArvore.Location = new System.Drawing.Point(36, 57);
            this.txtFKArvore.Name = "txtFKArvore";
            this.txtFKArvore.Size = new System.Drawing.Size(47, 20);
            this.txtFKArvore.TabIndex = 24;
            // 
            // txtIDColheita
            // 
            this.txtIDColheita.Location = new System.Drawing.Point(36, 30);
            this.txtIDColheita.Name = "txtIDColheita";
            this.txtIDColheita.Size = new System.Drawing.Size(47, 20);
            this.txtIDColheita.TabIndex = 23;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(566, 20);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(62, 23);
            this.btnSalvar.TabIndex = 22;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // bntAlterar
            // 
            this.bntAlterar.Location = new System.Drawing.Point(566, 49);
            this.bntAlterar.Name = "bntAlterar";
            this.bntAlterar.Size = new System.Drawing.Size(62, 23);
            this.bntAlterar.TabIndex = 21;
            this.bntAlterar.Text = "Alterar";
            this.bntAlterar.UseVisualStyleBackColor = true;
            this.bntAlterar.Click += new System.EventHandler(this.bntAlterar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(566, 78);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(62, 23);
            this.btnExcluir.TabIndex = 20;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(233, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Peso Bruto:";
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(301, 83);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(91, 20);
            this.txtPeso.TabIndex = 18;
            // 
            // txtDataColheita
            // 
            this.txtDataColheita.Location = new System.Drawing.Point(157, 83);
            this.txtDataColheita.Mask = "00/00/0000";
            this.txtDataColheita.Name = "txtDataColheita";
            this.txtDataColheita.Size = new System.Drawing.Size(70, 20);
            this.txtDataColheita.TabIndex = 17;
            this.txtDataColheita.ValidatingType = typeof(System.DateTime);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(103, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Colheita:";
            // 
            // lblFKArvore
            // 
            this.lblFKArvore.AutoSize = true;
            this.lblFKArvore.Location = new System.Drawing.Point(9, 60);
            this.lblFKArvore.Name = "lblFKArvore";
            this.lblFKArvore.Size = new System.Drawing.Size(21, 13);
            this.lblFKArvore.TabIndex = 12;
            this.lblFKArvore.Text = "ID:";
            // 
            // cbbArvore
            // 
            this.cbbArvore.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbArvore.FormattingEnabled = true;
            this.cbbArvore.Location = new System.Drawing.Point(158, 56);
            this.cbbArvore.Name = "cbbArvore";
            this.cbbArvore.Size = new System.Drawing.Size(368, 21);
            this.cbbArvore.TabIndex = 10;
            this.cbbArvore.SelectedIndexChanged += new System.EventHandler(this.cbbArvore_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(111, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Arvore:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Informações:";
            // 
            // txtInformacao
            // 
            this.txtInformacao.Location = new System.Drawing.Point(158, 30);
            this.txtInformacao.Name = "txtInformacao";
            this.txtInformacao.Size = new System.Drawing.Size(368, 20);
            this.txtInformacao.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // gridColheita
            // 
            this.gridColheita.AllowUserToAddRows = false;
            this.gridColheita.AllowUserToDeleteRows = false;
            this.gridColheita.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridColheita.Location = new System.Drawing.Point(12, 197);
            this.gridColheita.Name = "gridColheita";
            this.gridColheita.ReadOnly = true;
            this.gridColheita.Size = new System.Drawing.Size(634, 183);
            this.gridColheita.TabIndex = 18;
            this.gridColheita.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridColheita_CellClick);
            // 
            // btnPesquisa
            // 
            this.btnPesquisa.Location = new System.Drawing.Point(118, 168);
            this.btnPesquisa.Name = "btnPesquisa";
            this.btnPesquisa.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisa.TabIndex = 16;
            this.btnPesquisa.Text = "Pesquisa";
            this.btnPesquisa.UseVisualStyleBackColor = true;
            this.btnPesquisa.Click += new System.EventHandler(this.btnPesquisa_Click);
            // 
            // txtPesqID
            // 
            this.txtPesqID.Location = new System.Drawing.Point(48, 170);
            this.txtPesqID.Name = "txtPesqID";
            this.txtPesqID.Size = new System.Drawing.Size(64, 20);
            this.txtPesqID.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "ID:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(398, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "KG";
            // 
            // frmColheita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 420);
            this.ControlBox = false;
            this.Controls.Add(this.txtPesqID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gridColheita);
            this.Controls.Add(this.btnPesquisa);
            this.Controls.Add(this.panelFecha);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(658, 420);
            this.MinimumSize = new System.Drawing.Size(658, 420);
            this.Name = "frmColheita";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmColheita";
            this.Load += new System.EventHandler(this.frmColheita_Load);
            this.panelFecha.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridColheita)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFecha;
        private System.Windows.Forms.Panel panelFecha;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblFKArvore;
        private System.Windows.Forms.ComboBox cbbArvore;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtInformacao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gridColheita;
        private System.Windows.Forms.Button btnPesquisa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.MaskedTextBox txtDataColheita;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button bntAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.TextBox txtIDColheita;
        private System.Windows.Forms.TextBox txtFKArvore;
        private System.Windows.Forms.TextBox txtPesqID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}