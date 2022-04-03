namespace Desafio_Pomar
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnRelatorio = new System.Windows.Forms.Button();
            this.btnCadColheita = new System.Windows.Forms.Button();
            this.btnGrupoArvore = new System.Windows.Forms.Button();
            this.btnCadArvores = new System.Windows.Forms.Button();
            this.bntCadEspecie = new System.Windows.Forms.Button();
            this.panelFecha = new System.Windows.Forms.Panel();
            this.btnCriarBanco = new System.Windows.Forms.Button();
            this.btnFecha = new System.Windows.Forms.Button();
            this.panelMenu.SuspendLayout();
            this.panelFecha.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.SlateGray;
            this.panelMenu.Controls.Add(this.btnRelatorio);
            this.panelMenu.Controls.Add(this.btnCadColheita);
            this.panelMenu.Controls.Add(this.btnGrupoArvore);
            this.panelMenu.Controls.Add(this.btnCadArvores);
            this.panelMenu.Controls.Add(this.bntCadEspecie);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(4);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(206, 554);
            this.panelMenu.TabIndex = 0;
            // 
            // btnRelatorio
            // 
            this.btnRelatorio.BackColor = System.Drawing.Color.Transparent;
            this.btnRelatorio.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRelatorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRelatorio.ForeColor = System.Drawing.Color.White;
            this.btnRelatorio.Location = new System.Drawing.Point(0, 200);
            this.btnRelatorio.Name = "btnRelatorio";
            this.btnRelatorio.Size = new System.Drawing.Size(206, 50);
            this.btnRelatorio.TabIndex = 5;
            this.btnRelatorio.Text = "RELATORIOS DE COLHEITAS";
            this.btnRelatorio.UseVisualStyleBackColor = false;
            this.btnRelatorio.Click += new System.EventHandler(this.btnRelatorio_Click);
            // 
            // btnCadColheita
            // 
            this.btnCadColheita.BackColor = System.Drawing.Color.Transparent;
            this.btnCadColheita.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCadColheita.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadColheita.ForeColor = System.Drawing.Color.White;
            this.btnCadColheita.Location = new System.Drawing.Point(0, 150);
            this.btnCadColheita.Name = "btnCadColheita";
            this.btnCadColheita.Size = new System.Drawing.Size(206, 50);
            this.btnCadColheita.TabIndex = 4;
            this.btnCadColheita.Text = "CADASTRAR COLHEITA";
            this.btnCadColheita.UseVisualStyleBackColor = false;
            this.btnCadColheita.Click += new System.EventHandler(this.btnCadColheita_Click);
            // 
            // btnGrupoArvore
            // 
            this.btnGrupoArvore.BackColor = System.Drawing.Color.Transparent;
            this.btnGrupoArvore.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGrupoArvore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGrupoArvore.ForeColor = System.Drawing.Color.White;
            this.btnGrupoArvore.Location = new System.Drawing.Point(0, 100);
            this.btnGrupoArvore.Name = "btnGrupoArvore";
            this.btnGrupoArvore.Size = new System.Drawing.Size(206, 50);
            this.btnGrupoArvore.TabIndex = 3;
            this.btnGrupoArvore.Text = " CADASTRAR GRUPO DE ARVORES ";
            this.btnGrupoArvore.UseVisualStyleBackColor = false;
            this.btnGrupoArvore.Click += new System.EventHandler(this.btnGrupoArvore_Click);
            // 
            // btnCadArvores
            // 
            this.btnCadArvores.BackColor = System.Drawing.Color.Transparent;
            this.btnCadArvores.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCadArvores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadArvores.ForeColor = System.Drawing.Color.White;
            this.btnCadArvores.Location = new System.Drawing.Point(0, 50);
            this.btnCadArvores.Name = "btnCadArvores";
            this.btnCadArvores.Size = new System.Drawing.Size(206, 50);
            this.btnCadArvores.TabIndex = 2;
            this.btnCadArvores.Text = "CADASTRAR ARVORES";
            this.btnCadArvores.UseVisualStyleBackColor = false;
            this.btnCadArvores.Click += new System.EventHandler(this.btnCadArvores_Click);
            // 
            // bntCadEspecie
            // 
            this.bntCadEspecie.BackColor = System.Drawing.Color.Transparent;
            this.bntCadEspecie.Dock = System.Windows.Forms.DockStyle.Top;
            this.bntCadEspecie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntCadEspecie.ForeColor = System.Drawing.Color.White;
            this.bntCadEspecie.Location = new System.Drawing.Point(0, 0);
            this.bntCadEspecie.Margin = new System.Windows.Forms.Padding(0);
            this.bntCadEspecie.Name = "bntCadEspecie";
            this.bntCadEspecie.Size = new System.Drawing.Size(206, 50);
            this.bntCadEspecie.TabIndex = 1;
            this.bntCadEspecie.Text = "CADASTRAR ESPÉCIES";
            this.bntCadEspecie.UseVisualStyleBackColor = false;
            this.bntCadEspecie.Click += new System.EventHandler(this.bntCadEspecie_Click);
            // 
            // panelFecha
            // 
            this.panelFecha.BackColor = System.Drawing.Color.SlateGray;
            this.panelFecha.Controls.Add(this.btnCriarBanco);
            this.panelFecha.Controls.Add(this.btnFecha);
            this.panelFecha.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFecha.Location = new System.Drawing.Point(206, 0);
            this.panelFecha.Name = "panelFecha";
            this.panelFecha.Size = new System.Drawing.Size(994, 31);
            this.panelFecha.TabIndex = 2;
            this.panelFecha.Paint += new System.Windows.Forms.PaintEventHandler(this.panelFecha_Paint);
            // 
            // btnCriarBanco
            // 
            this.btnCriarBanco.BackColor = System.Drawing.Color.Transparent;
            this.btnCriarBanco.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCriarBanco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCriarBanco.ForeColor = System.Drawing.Color.White;
            this.btnCriarBanco.Location = new System.Drawing.Point(0, 0);
            this.btnCriarBanco.Name = "btnCriarBanco";
            this.btnCriarBanco.Size = new System.Drawing.Size(128, 31);
            this.btnCriarBanco.TabIndex = 7;
            this.btnCriarBanco.Text = "Criar Banco";
            this.btnCriarBanco.UseVisualStyleBackColor = false;
            this.btnCriarBanco.Click += new System.EventHandler(this.btnCriarBanco_Click);
            // 
            // btnFecha
            // 
            this.btnFecha.BackColor = System.Drawing.Color.Transparent;
            this.btnFecha.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnFecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFecha.ForeColor = System.Drawing.Color.Red;
            this.btnFecha.Location = new System.Drawing.Point(919, 0);
            this.btnFecha.Name = "btnFecha";
            this.btnFecha.Size = new System.Drawing.Size(75, 31);
            this.btnFecha.TabIndex = 6;
            this.btnFecha.Text = "X";
            this.btnFecha.UseVisualStyleBackColor = false;
            this.btnFecha.Click += new System.EventHandler(this.btnFecha_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 554);
            this.ControlBox = false;
            this.Controls.Add(this.panelFecha);
            this.Controls.Add(this.panelMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1200, 554);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1200, 554);
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pomar";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelFecha.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnRelatorio;
        private System.Windows.Forms.Button btnCadColheita;
        private System.Windows.Forms.Button btnGrupoArvore;
        private System.Windows.Forms.Button btnCadArvores;
        private System.Windows.Forms.Button bntCadEspecie;
        private System.Windows.Forms.Panel panelFecha;
        private System.Windows.Forms.Button btnFecha;
        private System.Windows.Forms.Button btnCriarBanco;
    }
}

