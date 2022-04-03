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
    public partial class frmEspecies : Form
    {
        public frmEspecies()
        {
            InitializeComponent();
        }
        //-----------------------METODOS REUTILIZAVEIS -------------------
        //carrega os dados
        private void ExibirDados()
        {
            try
            {
                DataTable dt = new DataTable();
                dt = DalHelper.GetTBEspecies();
                gridEspecies.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro : " + ex.Message);
            }
        }
        //verifica campo vazio
        private bool Valida()
        {
            if (string.IsNullOrEmpty(txtID.Text) && string.IsNullOrEmpty(txtEspecie.Text))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        //limpa os dados
        private void LimpaDados()
        {
            txtID.Text = "";
            txtEspecie.Text = "";
            txtPesqId.Text = "";
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
                Especies esp = new Especies();
                esp.IdEspecie = Convert.ToInt32(txtID.Text);
                esp.DescEspecies = txtEspecie.Text;
                DalHelper.Add(esp);
                ExibirDados();
                LimpaDados();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro : " + ex.Message);
            }
        }

        private void frmEspecies_Load(object sender, EventArgs e)
        {
            ExibirDados();
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
                Especies esp = new Especies();
                esp.IdEspecie = Convert.ToInt32(txtID.Text);
                esp.DescEspecies = txtEspecie.Text;
                DalHelper.Update(esp);
                ExibirDados();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro : " + ex.Message);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtID.Text))
            {
                MessageBox.Show("INFORME O ID PARA EXCLUIR");
                return;
            }

            try
            {
                int codigo = Convert.ToInt32(txtID.Text);
                DalHelper.Delete(codigo);
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
                dt = DalHelper.GetTBEspecie(codigo);
                gridEspecies.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro : " + ex.Message);
            }
        }

        private void gridEspecies_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.gridEspecies.Rows[e.RowIndex];
                txtID.Text = row.Cells["IDEspecies"].Value.ToString();
                txtEspecie.Text = row.Cells["DescEspecies"].Value.ToString();
            }
        }

        private void gridEspecies_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
