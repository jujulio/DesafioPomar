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
    public partial class frmArvores : Form
    {
        
        public frmArvores()
        {
            InitializeComponent();
        }


        //-----------------------METODOS REUTILIZAVEIS -------------------
        private void ExibirDados()
        {
            try
            {
                DataTable dt = new DataTable();
                dt = DalHelper.GetTBArvores();
                gridArvore.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro : " + ex.Message);
            }
        }
     
        private void CarregaCBB()
        {
            cbbEspecie.DataSource = DalHelper.GetTBEspecies();
            cbbEspecie.ValueMember = "IDEspecies";
            cbbEspecie.DisplayMember = "DescEspecies";
            cbbEspecie.Text = "Selecione a Especie";
            LimpaDados();
        }

        
        private bool Valida()
        {
            if (string.IsNullOrEmpty(txtIDArvore.Text) && string.IsNullOrEmpty(txtArvore.Text))
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
            txtArvore.Text = "";
            txtidade.Text = "";
            txtIDArvore.Text = "";
            txtPesqId.Text = "";
            txtFKEspecie.Text = "";
            

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

        private void panelFecha_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void frmArvores_Load(object sender, EventArgs e)
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
                
                Arvores arv = new Arvores();
                arv.IdArvore = Convert.ToInt32(txtIDArvore.Text);
                arv.DescArvore = txtArvore.Text;
                arv.IdadeArvore = txtidade.Text;
                arv.EspecieArvore = Convert.ToInt32(txtFKEspecie.Text);
                DalHelper.AddArvore(arv);
                ExibirDados();
                LimpaDados();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro : " + ex.Message);
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (!Valida())
            {
                MessageBox.Show("INFORME OS DADOS PARA ATUALIZAR");
                return;
            }

            try
            {
                Arvores arv = new Arvores();
                arv.IdArvore = Convert.ToInt32(txtIDArvore.Text);
                arv.DescArvore = txtArvore.Text;
                arv.EspecieArvore = Convert.ToInt32(txtFKEspecie.Text);
                arv.IdadeArvore = txtidade.Text;
                DalHelper.UpdateArvore(arv);
                ExibirDados();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro : " + ex.Message);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIDArvore.Text))
            {
                MessageBox.Show("INFORME O ID PARA EXCLUIR");
                return;
            }

            try
            {
                int codigo = Convert.ToInt32(txtIDArvore.Text);
                DalHelper.DeleteArvore(codigo);
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
            if (string.IsNullOrEmpty(txtPesqId.Text))
            {
                MessageBox.Show("INFORME O ID PARA LOCALIZAR");
                return;
            }
            try
            {
                DataTable dt = new DataTable();
                int codigo = Convert.ToInt32(txtPesqId.Text);
                dt = DalHelper.GetTBArvore(codigo);
                gridArvore.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro : " + ex.Message);
            }
        }

        private void gridArvore_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.gridArvore.Rows[e.RowIndex];
                txtIDArvore.Text = row.Cells["IdArvore"].Value.ToString();
                txtArvore.Text = row.Cells["DescArvore"].Value.ToString();
                txtFKEspecie.Text = row.Cells["FK_Especies"].Value.ToString();
                txtidade.Text = row.Cells["Idade"].Value.ToString();
                cbbEspecie.Text = row.Cells["DescEspecies"].Value.ToString();


            }
        }

  

        
        private void cbbEspecie_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            Especies esp = new Especies();

           int codigo = Convert.ToInt32(((DataRowView)cbbEspecie.SelectedItem)["IDEspecies"]);

            esp = DalHelper.GetEspeciesCBB(codigo);
            PreencheDados(esp);
        }
        private void PreencheDados(Especies esp)
        {
            txtFKEspecie.Text = esp.IdEspecie.ToString();
            
        }

        private void gridArvore_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
