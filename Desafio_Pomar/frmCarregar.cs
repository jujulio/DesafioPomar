using System;
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
    public partial class frmCarregar : Form
    {
        public frmCarregar()
        {
            InitializeComponent();
        }

        private void frmCarregar_Load(object sender, EventArgs e)
        {
            this.timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           if(carrega.Value < 100)
            {
                carrega.Value += 5;
            }
            else
            {
                this.timer1.Stop();
                FrmPrincipal principal = new FrmPrincipal();
                principal.Show();
                this.Visible = false;


                
            }
           
           
        }
    }
}
