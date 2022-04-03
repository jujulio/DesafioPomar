namespace Desafio_Pomar
{
    partial class frmRelatorio
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
            this.btnParvore = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPeriodo = new System.Windows.Forms.MaskedTextBox();
            this.btnPperiodo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtArvore = new System.Windows.Forms.TextBox();
            this.ckPeriodo = new System.Windows.Forms.CheckBox();
            this.ckNome = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gridRelatorio = new System.Windows.Forms.DataGridView();
            this.panelFecha.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridRelatorio)).BeginInit();
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
            // btnParvore
            // 
            this.btnParvore.Location = new System.Drawing.Point(278, 40);
            this.btnParvore.Name = "btnParvore";
            this.btnParvore.Size = new System.Drawing.Size(59, 23);
            this.btnParvore.TabIndex = 7;
            this.btnParvore.Text = "Pesquisa";
            this.btnParvore.UseVisualStyleBackColor = true;
            this.btnParvore.Click += new System.EventHandler(this.btnParvore_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPeriodo);
            this.groupBox1.Controls.Add(this.btnPperiodo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtArvore);
            this.groupBox1.Controls.Add(this.ckPeriodo);
            this.groupBox1.Controls.Add(this.ckNome);
            this.groupBox1.Controls.Add(this.btnParvore);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(634, 76);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Pesquisa";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtPeriodo
            // 
            this.txtPeriodo.Location = new System.Drawing.Point(393, 42);
            this.txtPeriodo.Mask = "00/00/0000";
            this.txtPeriodo.Name = "txtPeriodo";
            this.txtPeriodo.Size = new System.Drawing.Size(72, 20);
            this.txtPeriodo.TabIndex = 14;
            this.txtPeriodo.ValidatingType = typeof(System.DateTime);
            // 
            // btnPperiodo
            // 
            this.btnPperiodo.Location = new System.Drawing.Point(471, 40);
            this.btnPperiodo.Name = "btnPperiodo";
            this.btnPperiodo.Size = new System.Drawing.Size(59, 23);
            this.btnPperiodo.TabIndex = 13;
            this.btnPperiodo.Text = "Pesquisa";
            this.btnPperiodo.UseVisualStyleBackColor = true;
            this.btnPperiodo.Click += new System.EventHandler(this.btnPperiodo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(349, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Periodo:";
            // 
            // txtArvore
            // 
            this.txtArvore.Location = new System.Drawing.Point(51, 42);
            this.txtArvore.Name = "txtArvore";
            this.txtArvore.Size = new System.Drawing.Size(221, 20);
            this.txtArvore.TabIndex = 11;
            // 
            // ckPeriodo
            // 
            this.ckPeriodo.AutoSize = true;
            this.ckPeriodo.Location = new System.Drawing.Point(280, 10);
            this.ckPeriodo.Name = "ckPeriodo";
            this.ckPeriodo.Size = new System.Drawing.Size(62, 17);
            this.ckPeriodo.TabIndex = 10;
            this.ckPeriodo.Text = "Periodo";
            this.ckPeriodo.UseVisualStyleBackColor = true;
            this.ckPeriodo.CheckedChanged += new System.EventHandler(this.ckPeriodo_CheckedChanged);
            // 
            // ckNome
            // 
            this.ckNome.AutoSize = true;
            this.ckNome.Location = new System.Drawing.Point(215, 10);
            this.ckNome.Name = "ckNome";
            this.ckNome.Size = new System.Drawing.Size(57, 17);
            this.ckNome.TabIndex = 9;
            this.ckNome.Text = "Arvore";
            this.ckNome.UseVisualStyleBackColor = true;
            this.ckNome.CheckedChanged += new System.EventHandler(this.ckNome_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nome:";
            // 
            // gridRelatorio
            // 
            this.gridRelatorio.AllowUserToAddRows = false;
            this.gridRelatorio.AllowUserToDeleteRows = false;
            this.gridRelatorio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridRelatorio.Location = new System.Drawing.Point(12, 110);
            this.gridRelatorio.Name = "gridRelatorio";
            this.gridRelatorio.ReadOnly = true;
            this.gridRelatorio.Size = new System.Drawing.Size(634, 298);
            this.gridRelatorio.TabIndex = 9;
            // 
            // frmRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 420);
            this.ControlBox = false;
            this.Controls.Add(this.gridRelatorio);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panelFecha);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(658, 420);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(658, 420);
            this.Name = "frmRelatorio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRelatorio";
            this.Load += new System.EventHandler(this.frmRelatorio_Load);
            this.panelFecha.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridRelatorio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFecha;
        private System.Windows.Forms.Panel panelFecha;
        private System.Windows.Forms.Button btnParvore;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView gridRelatorio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox ckPeriodo;
        private System.Windows.Forms.CheckBox ckNome;
        private System.Windows.Forms.TextBox txtArvore;
        private System.Windows.Forms.Button btnPperiodo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtPeriodo;
    }
}