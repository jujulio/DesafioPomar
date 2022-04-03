using System;
using Desafio_Pomar.Models;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desafio_Pomar
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }
        private void CriarTabelasDB()
        {
            try
            {
                DalHelper.CriarTabelaTBEspecies();
                MessageBox.Show("TABELA ESPECIE CRIADO COM SUCESSO ");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro : " + ex.Message);
            }
            try
            {
                DalHelper.CriarTabelaTBArvores();
                MessageBox.Show("TABELAS ARVORE CRIADO COM SUCESSO ");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro : " + ex.Message);
            }
            try
            {
                DalHelper.CriarTabelaTBGrupoArvore();
                MessageBox.Show("TABELA GRUPO ARVORE CRIADO COM SUCESSO ");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro : " + ex.Message);
            }
            try
            {
                DalHelper.CriarTabelaTBColheitas();
                MessageBox.Show("TABELA COLHEITAS CRIADO COM SUCESSO ");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro : " + ex.Message);
            }
           
        }
        private void bntCadEspecie_Click(object sender, EventArgs e)
        {
            if(Application.OpenForms.OfType<frmEspecies>().Count() > 0)
            {
                MessageBox.Show("FORMULARIO JÁ ESTÁ ABERTO!", "SISTEMA", MessageBoxButtons.OK);
            }
            else
            {
                var especies = new frmEspecies();
                especies.MdiParent = this;
                especies.Show();
            }
           

        }

        private void btnFecha_Click(object sender, EventArgs e)
        {
            DialogResult resp = MessageBox.Show("DESEJA SAIR?", "SISTEMA", MessageBoxButtons.YesNo);
            if(resp == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                
            }
        }

        private void panelFecha_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCadArvores_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmArvores>().Count() > 0)
            {
                MessageBox.Show("FORMULARIO JÁ ESTÁ ABERTO!", "SISTEMA", MessageBoxButtons.OK);
            }
            else
            {
                var arvores = new frmArvores();
                arvores.MdiParent = this;
                arvores.Show();
            }
        }

        private void btnGrupoArvore_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmGrupoArvore>().Count() > 0)
            {
                MessageBox.Show("FORMULARIO JÁ ESTÁ ABERTO!", "SISTEMA", MessageBoxButtons.OK);
            }
            else
            {
                var GrupoArvores = new frmGrupoArvore();
                GrupoArvores.MdiParent = this;
                GrupoArvores.Show();
            }
        }

        private void btnCadColheita_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmColheita>().Count() > 0)
            {
             DialogResult esp = MessageBox.Show("FORMULARIO JÁ ESTÁ ABERTO!", "SISTEMA", MessageBoxButtons.OK);
            }
            else
            {
                var colheita = new frmColheita();
                colheita.MdiParent = this;
                colheita.Show();
            }
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmRelatorio>().Count() > 0)
            {
                MessageBox.Show("FORMULARIO JÁ ESTÁ ABERTO!", "SISTEMA", MessageBoxButtons.OK);
            }
            else
            {
                var relatorio = new frmRelatorio();
                relatorio.MdiParent = this;
                relatorio.Show();
            }
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            
        }

        private void btnCriarBanco_Click(object sender, EventArgs e)
        {
            
            if (System.IO.File.Exists(@"C:\Desafio_Pomar\databasePomar\BancoPomar.sqlite"))
            {
                MessageBox.Show("O BANCO DE DADOS JÁ EXISTE", "SISTEMA", MessageBoxButtons.OK);
            }
           DialogResult resp = MessageBox.Show("DESEJA CRIAR UM NOVO BANCO DE DADOS?", "SISTEMA", MessageBoxButtons.YesNo);
            if (resp == DialogResult.Yes)
                {
                try
                {
                    DalHelper.CriarBancoSQLite();
                    btnCriarBanco.Enabled = false;
                    MessageBox.Show("BANCO CRIADO COM SUCESSO");
                    CriarTabelasDB();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro : " + ex.Message);
                }  
            }
            else
            {
                CriarTabelasDB();
            }
        }

        private void btnCriarTabela_Click(object sender, EventArgs e)
        {
           
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
           
        }
    }
}
