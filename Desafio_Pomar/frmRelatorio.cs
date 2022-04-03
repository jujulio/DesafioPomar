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
    public partial class frmRelatorio : Form
    {
        public frmRelatorio()
        {
            InitializeComponent();
        }
        
        private void ExibirDados()
        {
            try
            {
                DataTable dt = new DataTable();
                dt = DalHelper.GetRelatorioArvore();
                gridRelatorio.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro : " + ex.Message);
            }
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

      

        private void frmRelatorio_Load(object sender, EventArgs e)
        {
            ExibirDados();
            txtArvore.Enabled = false;
            btnParvore.Enabled = false;
            txtPeriodo.Enabled = false;
            btnPperiodo.Enabled = false;
           

        }

        private void ckNome_CheckedChanged(object sender, EventArgs e)
        {
            ckPeriodo.Checked = false;
            btnParvore.Enabled = true;
            txtArvore.Enabled = true;

            //----------------------
            txtPeriodo.Enabled = false;
            btnPperiodo.Enabled = false;
        }

        private void ckPeriodo_CheckedChanged(object sender, EventArgs e)
        {
            ckNome.Checked = false;
            btnParvore.Enabled = false;
            txtArvore.Enabled = false;

            //----------------------
            txtPeriodo.Enabled = true;
            btnPperiodo.Enabled = true;
        }

        private void btnParvore_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtArvore.Text))
            {
                MessageBox.Show("INFORME O ID PARA LOCALIZAR");

                return;
            }
            try
            {
                DataTable dt = new DataTable();
                string codigo = txtArvore.Text;
                dt = DalHelper.GetRelatorioArvores(codigo);
                gridRelatorio.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro : " + ex.Message);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnPperiodo_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPeriodo.Text))
            {
                MessageBox.Show("INFORME O ID PARA LOCALIZAR");

                return;
            }
            try
            {
                DataTable dt = new DataTable();
                string codigo = txtPeriodo.Text;
                dt = DalHelper.GetRelatorioArvores2(codigo);
                gridRelatorio.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro : " + ex.Message);
            }
        }
    }
    }

