namespace Desafio_Pomar
{
    partial class frmEspecies
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
            this.btnExcluir = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEspecie = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPesquisa = new System.Windows.Forms.Button();
            this.gridEspecies = new System.Windows.Forms.DataGridView();
            this.txtPesqId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panelFecha.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridEspecies)).BeginInit();
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
            this.panelFecha.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnExcluir);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.btnSalvar);
            this.groupBox1.Controls.Add(this.btnAlterar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtEspecie);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(634, 122);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastrar Espécies";
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(566, 77);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(62, 23);
            this.btnExcluir.TabIndex = 8;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(73, 27);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(47, 20);
            this.txtID.TabIndex = 7;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(566, 20);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(62, 23);
            this.btnSalvar.TabIndex = 6;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(566, 48);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(62, 23);
            this.btnAlterar.TabIndex = 5;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Descrição:";
            // 
            // txtEspecie
            // 
            this.txtEspecie.Location = new System.Drawing.Point(73, 53);
            this.txtEspecie.Name = "txtEspecie";
            this.txtEspecie.Size = new System.Drawing.Size(365, 20);
            this.txtEspecie.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // btnPesquisa
            // 
            this.btnPesquisa.Location = new System.Drawing.Point(112, 156);
            this.btnPesquisa.Name = "btnPesquisa";
            this.btnPesquisa.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisa.TabIndex = 5;
            this.btnPesquisa.Text = "Pesquisa";
            this.btnPesquisa.UseVisualStyleBackColor = true;
            this.btnPesquisa.Click += new System.EventHandler(this.btnPesquisa_Click);
            // 
            // gridEspecies
            // 
            this.gridEspecies.AllowUserToAddRows = false;
            this.gridEspecies.AllowUserToDeleteRows = false;
            this.gridEspecies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridEspecies.Location = new System.Drawing.Point(12, 185);
            this.gridEspecies.Name = "gridEspecies";
            this.gridEspecies.ReadOnly = true;
            this.gridEspecies.Size = new System.Drawing.Size(634, 183);
            this.gridEspecies.TabIndex = 7;
            this.gridEspecies.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridEspecies_CellClick);
            this.gridEspecies.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridEspecies_CellContentClick);
            // 
            // txtPesqId
            // 
            this.txtPesqId.Location = new System.Drawing.Point(41, 159);
            this.txtPesqId.Name = "txtPesqId";
            this.txtPesqId.Size = new System.Drawing.Size(65, 20);
            this.txtPesqId.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "ID:";
            // 
            // frmEspecies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 420);
            this.ControlBox = false;
            this.Controls.Add(this.txtPesqId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gridEspecies);
            this.Controls.Add(this.btnPesquisa);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panelFecha);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(658, 420);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(658, 420);
            this.Name = "frmEspecies";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEspecies";
            this.Load += new System.EventHandler(this.frmEspecies_Load);
            this.panelFecha.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridEspecies)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFecha;
        private System.Windows.Forms.Panel panelFecha;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEspecie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPesquisa;
        private System.Windows.Forms.DataGridView gridEspecies;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.TextBox txtPesqId;
        private System.Windows.Forms.Label label3;
    }
}