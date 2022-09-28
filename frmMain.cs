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

        // constantes para los cálculos
 private const float TIPOA = 20;
 public const float TIPOB = 34;
 const float COCINA = 1;
 const float HELADERA = 1.5f;
 const float TELEVISOR = 2;
 const float PORPERSONA = 1;

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            
            cmbTipos.Items.Clear();
            cmbTipos.Items.Add("Tipo A");
            cmbTipos.Items.Add("Tipo B");
            
            cmbTipos.SelectedIndex = 0;
            
            txtDias.Text = "";
            
            chkCocina.Checked = false;
            chkHeladera.Checked = false;
            chkTele.Checked = false;
            
            optEfectivo.Checked = true;
            txtNombre.Text = "";
            txtTelefono.Text = "";
            
            cmbTarjetas.Items.Clear();
            cmbTarjetas.Items.Add("Card Red");
            cmbTarjetas.Items.Add("Card Green");
            cmbTarjetas.Items.Add("Card Blue");
            
            btnAceptar.Enabled = false;



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cmbTipos_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (cmbTipos.SelectedIndex != -1) //es lo mismo que (.Text != "") este hace que si no hay nada no se habilite -1 es que no esta seleccionado
            //{
            //    cmbPersonas.Enabled = true;
            //}
            //else
            //{
            //    cmbPersonas.Enabled = false;
            //}

            int I = 0;
            
            cmbPersonas.Items.Clear();
            
            if (cmbTipos.SelectedIndex == 0) 
            {
                for (I = 1; I <= 4; I++)
                {
                    cmbPersonas.Items.Add(I);
                }
            }
            else
            { 
                for (I = 1; I <= 8; I++)
                {
                    cmbPersonas.Items.Add(I);
                }
            }

            cmbPersonas.SelectedIndex = 0;
            
        }

        private void cmbPersonas_SelectedIndexChanged(object sender, EventArgs e)
        {

            //if (cmbPersonas.Text != "")
            //{
            //    txtDias.Enabled = true;
            //}
            //else
            //{
            //    txtDias.Enabled = false;
            //}

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
                mrcTitular.Enabled = false;
            }

        }

        private void optTarjeta_CheckedChanged(object sender, EventArgs e)
        {
            if (optTarjeta.Checked == true)
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

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            if (txtNombre.Text != "")
            {
                txtTelefono.Enabled = true;
            }
            else
            {
                txtTelefono.Enabled = false;
            }

        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {
            if (txtTelefono.Text != "")
            {
                btnAceptar.Enabled = true;
            }
            else
            {
                btnAceptar.Enabled = false;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            float PrecioBase;
            float Opcionales;
            float Recargo;
            int Dias;
            float Total;

            Dias = int.Parse(txtDias.Text);

            if (cmbTipos.SelectedIndex == 0)
            {
                PrecioBase = TIPOA;
            }
            else
            {
                PrecioBase = TIPOB;
            }
            
            PrecioBase = PrecioBase + (PORPERSONA * int.Parse(cmbPersonas.Text));
           
            Opcionales = 0;
            if (chkCocina.Checked == true)
            {
                Opcionales = Opcionales + COCINA;
            }
            if (chkHeladera.Checked == true)
            {
                Opcionales = Opcionales + HELADERA;
            }
            if (chkTele.Checked == true)
            {
                Opcionales = Opcionales + TELEVISOR;
            }
            
            Total = (PrecioBase + Opcionales) * Dias;
    
            if (optTarjeta.Checked == true)
            {
                if (cmbTarjetas.SelectedIndex == 0)
                {
                    Recargo = Total * 10 / 100;
                }
                else
                {
                    Recargo = Total * 20 / 100;
                }
                Total = Total + Recargo;
            }
            
            MessageBox.Show("Total = " + Total.ToString(), "Importe de la reserva",
            MessageBoxButtons.OK, MessageBoxIcon.Information);

            cmbTipos.SelectedIndex = 0;
            txtDias.Text = "1";
            chkCocina.Checked = false;
            chkHeladera.Checked = false;
            chkTele.Checked = false;
            optEfectivo.Checked = true;
            txtNombre.Text = "";
            txtTelefono.Text = "";

        }

        private void txtDias_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
