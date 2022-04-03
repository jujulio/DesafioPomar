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
    public partial class frmGrupoArvore : Form
    {
        //-----------------------METODOS REUTILIZAVEIS -------------------
        private void ExibirDados()
        {
            try
            {
                DataTable dt = new DataTable();
                dt = DalHelper.GetTBGrupoArvores();
                gridGrupoArvore.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro : " + ex.Message);
            }
        }

        private void CarregaCBB()
        {
            cbbArvore.DataSource = DalHelper.GetTBArvores();
            cbbArvore.ValueMember = "IDArvore";
            cbbArvore.DisplayMember = "DescArvore";
            cbbArvore.Text = "Selecione a Arvore";

            LimpaDados();
        }


        private bool Valida()
        {
            if (string.IsNullOrEmpty(txtIDGrupo.Text) && string.IsNullOrEmpty(txtGrupo.Text))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private void LimpaDados()
        {
            txtDescGrupo.Text = "";
            txtFKArvore.Text = "";
            txtGrupo.Text = "";
            txtPesqId.Text = "";
            txtIDGrupo.Text = "";
          

        }

        //----------------------- FIM METODOS REUTILIZAVEIS -------------------
        public frmGrupoArvore()
        {
            InitializeComponent();
        }

        private void btnFecha_Click(object sender, EventArgs e)
        {
            DialogResult resp = MessageBox.Show("DESEJA FECHAR FORMULARIO?", "SISTEMA", MessageBoxButtons.YesNo);
            if (resp == DialogResult.Yes)
            {

                this.Close();
            }
            else
            {

            }
        }

        private void frmGrupoArvore_Load(object sender, EventArgs e)
        {
            LimpaDados();
            ExibirDados();
            CarregaCBB();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (!Valida())
            {
                MessageBox.Show("INFORME OS DADOS PARA INCLUIR");
                return;
            }

            try
            {
                GrupoArvore grupoArv = new GrupoArvore();
                grupoArv.IdGrupoArvore = Convert.ToInt32(txtIDGrupo.Text);
                grupoArv.NomeGrupoArvore = txtGrupo.Text;
                grupoArv.DescGrupoArvore = txtDescGrupo.Text;
                grupoArv.TipoArvore = Convert.ToInt32(txtFKArvore.Text);
                DalHelper.AddGrupoArvore(grupoArv);
                ExibirDados();
                LimpaDados();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro : " + ex.Message);
            }
        }

        private void bntAlterar_Click(object sender, EventArgs e)
        {
            if (!Valida())
            {
                MessageBox.Show("INFORME OS DADOS PARA ATUALIZAR");
                return;
            }

            try
            {
                GrupoArvore grupoArv = new GrupoArvore();
                grupoArv.IdGrupoArvore = Convert.ToInt32(txtIDGrupo.Text);
                grupoArv.NomeGrupoArvore = txtGrupo.Text;
                grupoArv.DescGrupoArvore = txtDescGrupo.Text;
                grupoArv.TipoArvore = Convert.ToInt32(txtFKArvore.Text);
                DalHelper.UpdateGrupoArvore(grupoArv);
                ExibirDados();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro : " + ex.Message);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIDGrupo.Text))
            {
                MessageBox.Show("INFORME O ID PARA EXCLUIR");
                return;
            }

            try
            {
                int codigo = Convert.ToInt32(txtIDGrupo.Text);
                DalHelper.DeleteGrupoArvore(codigo);
                ExibirDados();
                LimpaDados();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro : " + ex.Message);
            }
        }

        private void cbbArvore_SelectedIndexChanged(object sender, EventArgs e)
        {
            Arvores arv = new Arvores();

            int codigo = Convert.ToInt32(((DataRowView)cbbArvore.SelectedItem)["IDArvore"]);

            arv = DalHelper.GetArvoreCBB(codigo);
            PreencheDados(arv);
        }
        private void PreencheDados(Arvores arv)
        {
            txtFKArvore.Text = arv.IdArvore.ToString();

        }

        private void gridGrupoArvore_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gridGrupoArvore_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.gridGrupoArvore.Rows[e.RowIndex];
                txtIDGrupo.Text = row.Cells["IDGrupo"].Value.ToString();
                txtGrupo.Text = row.Cells["NomeGrupo"].Value.ToString();
                txtDescGrupo.Text = row.Cells["DesGrupo"].Value.ToString();
                txtFKArvore.Text = row.Cells["FK_Arvore"].Value.ToString();
                cbbArvore.Text = row.Cells["DescArvore"].Value.ToString();

            }
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPesqId.Text))
            {
                MessageBox.Show("INFORME O ID PARA LOCALIZAR");
                
                return;
            }
            try
            {
                DataTable dt = new DataTable();
                int codigo = Convert.ToInt32(txtPesqId.Text);
                dt = DalHelper.GetTBGrupoArvore(codigo);
                gridGrupoArvore.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro : " + ex.Message);
            }
            
        }
        
    }
    }
