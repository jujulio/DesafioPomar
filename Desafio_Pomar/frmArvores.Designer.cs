namespace Desafio_Pomar
{
    partial class frmArvores
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
            this.components = new System.ComponentModel.Container();
            this.btnFecha = new System.Windows.Forms.Button();
            this.panelFecha = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtFKEspecie = new System.Windows.Forms.TextBox();
            this.txtIDArvore = new System.Windows.Forms.TextBox();
            this.labelespecie = new System.Windows.Forms.Label();
            this.cbbEspecie = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtidade = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtArvore = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gridArvore = new System.Windows.Forms.DataGridView();
            this.btnPesquisa = new System.Windows.Forms.Button();
            this.txtPesqId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dalHelperBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelFecha.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridArvore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dalHelperBindingSource)).BeginInit();
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
            this.panelFecha.TabIndex = 4;
            this.panelFecha.Paint += new System.Windows.Forms.PaintEventHandler(this.panelFecha_Paint);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtFKEspecie);
            this.groupBox1.Controls.Add(this.txtIDArvore);
            this.groupBox1.Controls.Add(this.labelespecie);
            this.groupBox1.Controls.Add(this.cbbEspecie);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtidade);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnSalvar);
            this.groupBox1.Controls.Add(this.btnAlterar);
            this.groupBox1.Controls.Add(this.btnExcluir);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtArvore);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(634, 108);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastrar Arvores";
            // 
            // txtFKEspecie
            // 
            this.txtFKEspecie.Enabled = false;
            this.txtFKEspecie.Location = new System.Drawing.Point(34, 57);
            this.txtFKEspecie.Name = "txtFKEspecie";
            this.txtFKEspecie.Size = new System.Drawing.Size(42, 20);
            this.txtFKEspecie.TabIndex = 12;
            // 
            // txtIDArvore
            // 
            this.txtIDArvore.Location = new System.Drawing.Point(34, 26);
            this.txtIDArvore.Name = "txtIDArvore";
            this.txtIDArvore.Size = new System.Drawing.Size(42, 20);
            this.txtIDArvore.TabIndex = 11;
            // 
            // labelespecie
            // 
            this.labelespecie.AutoSize = true;
            this.labelespecie.Location = new System.Drawing.Point(7, 60);
            this.labelespecie.Name = "labelespecie";
            this.labelespecie.Size = new System.Drawing.Size(18, 13);
            this.labelespecie.TabIndex = 11;
            this.labelespecie.Text = "ID";
            this.labelespecie.Click += new System.EventHandler(this.label5_Click);
            // 
            // cbbEspecie
            // 
            this.cbbEspecie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbEspecie.FormattingEnabled = true;
            this.cbbEspecie.Location = new System.Drawing.Point(136, 57);
            this.cbbEspecie.Name = "cbbEspecie";
            this.cbbEspecie.Size = new System.Drawing.Size(260, 21);
            this.cbbEspecie.TabIndex = 10;
            this.cbbEspecie.SelectedIndexChanged += new System.EventHandler(this.cbbEspecie_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(82, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Especie:";
            // 
            // txtidade
            // 
            this.txtidade.Location = new System.Drawing.Point(136, 88);
            this.txtidade.Mask = "00/00/0000";
            this.txtidade.Name = "txtidade";
            this.txtidade.Size = new System.Drawing.Size(70, 20);
            this.txtidade.TabIndex = 8;
            this.txtidade.ValidatingType = typeof(System.DateTime);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Idade:";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(570, 19);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(62, 23);
            this.btnSalvar.TabIndex = 6;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(570, 48);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(62, 23);
            this.btnAlterar.TabIndex = 5;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(570, 77);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(62, 23);
            this.btnExcluir.TabIndex = 4;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Descrição:";
            // 
            // txtArvore
            // 
            this.txtArvore.Location = new System.Drawing.Point(165, 27);
            this.txtArvore.Name = "txtArvore";
            this.txtArvore.Size = new System.Drawing.Size(340, 20);
            this.txtArvore.TabIndex = 2;
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
            // gridArvore
            // 
            this.gridArvore.AllowUserToAddRows = false;
            this.gridArvore.AllowUserToDeleteRows = false;
            this.gridArvore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridArvore.Location = new System.Drawing.Point(12, 184);
            this.gridArvore.Name = "gridArvore";
            this.gridArvore.ReadOnly = true;
            this.gridArvore.Size = new System.Drawing.Size(634, 183);
            this.gridArvore.TabIndex = 10;
            this.gridArvore.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridArvore_CellClick);
            this.gridArvore.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridArvore_CellContentClick);
            // 
            // btnPesquisa
            // 
            this.btnPesquisa.Location = new System.Drawing.Point(117, 156);
            this.btnPesquisa.Name = "btnPesquisa";
            this.btnPesquisa.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisa.TabIndex = 8;
            this.btnPesquisa.Text = "Pesquisa";
            this.btnPesquisa.UseVisualStyleBackColor = true;
            this.btnPesquisa.Click += new System.EventHandler(this.btnPesquisa_Click);
            // 
            // txtPesqId
            // 
            this.txtPesqId.Location = new System.Drawing.Point(46, 158);
            this.txtPesqId.Name = "txtPesqId";
            this.txtPesqId.Size = new System.Drawing.Size(65, 20);
            this.txtPesqId.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "ID:";
            // 
            // dalHelperBindingSource
            // 
            this.dalHelperBindingSource.DataSource = typeof(Desafio_Pomar.DalHelper);
            // 
            // frmArvores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 420);
            this.ControlBox = false;
            this.Controls.Add(this.txtPesqId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.gridArvore);
            this.Controls.Add(this.btnPesquisa);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panelFecha);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(658, 420);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(658, 420);
            this.Name = "frmArvores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmArvores";
            this.Load += new System.EventHandler(this.frmArvores_Load);
            this.panelFecha.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridArvore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dalHelperBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFecha;
        private System.Windows.Forms.Panel panelFecha;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtArvore;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbEspecie;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox txtidade;
        private System.Windows.Forms.DataGridView gridArvore;
        private System.Windows.Forms.Button btnPesquisa;
        private System.Windows.Forms.Label labelespecie;
        private System.Windows.Forms.TextBox txtIDArvore;
        private System.Windows.Forms.TextBox txtPesqId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFKEspecie;
        private System.Windows.Forms.BindingSource dalHelperBindingSource;
    }
}