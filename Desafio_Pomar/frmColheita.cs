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
    public partial class frmColheita : Form
    {
        public frmColheita()
        {
            InitializeComponent();
        }
        //-----------------------METODOS REUTILIZAVEIS -------------------
        private void ExibirDados()
        {
            try
            {
                DataTable dt = new DataTable();
                dt = DalHelper.GetTBColheitas();
                gridColheita.DataSource = dt;
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
            if (string.IsNullOrEmpty(txtIDColheita.Text) && string.IsNullOrEmpty(txtInformacao.Text))
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
            txtDataColheita.Text = "";
            txtFKArvore.Text = "";
            txtInformacao.Text = "";
            txtIDColheita.Text = "";
            txtPeso.Text = "";
            txtPesqID.Text = "";
            

        }

        //----------------------- FIM METODOS REUTILIZAVEIS -------------------

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

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (!Valida())
            {
                MessageBox.Show("INFORME OS DADOS PARA INCLUIR");
                return;
            }

            try
            {
                Colheita colheita = new Colheita();
                colheita.IDColheita = Convert.ToInt32(txtIDColheita.Text);
                colheita.Informacao = txtInformacao.Text;
                colheita.DataColheita = txtDataColheita.Text;
                colheita.Peso = Convert.ToDecimal(txtPeso.Text);
                colheita.TipoArvore = Convert.ToInt32(txtFKArvore.Text);
                DalHelper.AddColheitas(colheita);
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
                Colheita colheita = new Colheita();
                colheita.IDColheita = Convert.ToInt32(txtIDColheita.Text);
                colheita.Informacao = txtInformacao.Text;
                colheita.DataColheita = txtDataColheita.Text;
                colheita.Peso = Convert.ToDecimal(txtPeso.Text);
                colheita.TipoArvore = Convert.ToInt32(txtFKArvore.Text);
                DalHelper.UpdateColheitas(colheita);
                ExibirDados();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro : " + ex.Message);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIDColheita.Text))
            {
                MessageBox.Show("INFORME O ID PARA EXCLUIR");
                return;
            }

            try
            {
                int codigo = Convert.ToInt32(txtIDColheita.Text);
                DalHelper.DeleteColheitas(codigo);
                ExibirDados();
                LimpaDados();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro : " + ex.Message);
            }
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPesqID.Text))
            {
                MessageBox.Show("INFORME O ID PARA LOCALIZAR");

                return;
            }
            try
            {
                DataTable dt = new DataTable();
                int codigo = Convert.ToInt32(txtPesqID.Text);
                dt = DalHelper.GetTBColheita(codigo);
                gridColheita.DataSource = dt;
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

        private void frmColheita_Load(object sender, EventArgs e)
        {
            LimpaDados();
            ExibirDados();
            CarregaCBB();
        }

        private void gridColheita_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.gridColheita.Rows[e.RowIndex];
                txtIDColheita.Text = row.Cells["IDColheita"].Value.ToString();
                txtInformacao.Text = row.Cells["Informacao"].Value.ToString();
                txtPeso.Text = row.Cells["Peso"].Value.ToString();
                txtDataColheita.Text = row.Cells["DataColheita"].Value.ToString();
                txtFKArvore.Text = row.Cells["FK_Arvore"].Value.ToString();
                cbbArvore.Text = row.Cells["DescArvore"].Value.ToString();

            }
        }
    }
    }

