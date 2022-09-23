using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryArmaniniSp2Ejer1
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cmbTipos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTipos.SelectedIndex != -1) //es lo mismo que (.Text != "") este hace que si no hay nada no se habilite -1 es que no esta seleccionado
            {
                cmbPersonas.Enabled = true;
            }
            else
            {
                cmbPersonas.Enabled = false;
            }
        }

        private void cmbPersonas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPersonas.Text != "")
            {
                txtDias.Enabled = true;
            }
            else
            {
                txtDias.Enabled = false;
            }
        }

        private void txtDias_TextChanged(object sender, EventArgs e)
        {
            if (txtDias.Text != "")
            {
                mrcAdicionales.Enabled = true;
                mrcPagos.Enabled = true;
            }
            else
            {
                mrcAdicionales.Enabled = false;
                mrcPagos.Enabled = false;
            }
        }

        private void optEfectivo_CheckedChanged(object sender, EventArgs e)
        {
            if (optEfectivo.Checked == true)
            {
                cmbTarjetas.Enabled = false;
            }
            else
            {
                cmbTarjetas.Enabled = true;
            }
            if (optEfectivo.Checked == true)
            {
                mrcTitular.Enabled = true;
            }
            else
            {
                 mrcTitular.Enabled= false;
            }
        }

        private void optTarjeta_CheckedChanged(object sender, EventArgs e)
        {
            if(optTarjeta.Checked == true)
            {
                cmbTarjetas.Enabled = true;
            }
            else
            {
                cmbTarjetas.Enabled = false;
            }
        }

        private void cmbTarjetas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTarjetas.Text != "")
            {
                mrcTitular.Enabled = true;

            }
            else
            {
                mrcTitular.Enabled = false;
            }
        }
    }
}
