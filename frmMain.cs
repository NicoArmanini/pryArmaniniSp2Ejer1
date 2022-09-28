using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Librerias predeterminadas

namespace pryArmaniniSp2Ejer1
{
    public partial class frmMain : Form

    {
         //Float: flotante
         // Constantes de los calculos
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
        //private de privado, void de vacio, se carga este formulario
        //(se determinan los parametros)
        private void frmMain_Load(object sender, EventArgs e)
        {
            
            cmbTipos.Items.Clear();
            cmbTipos.Items.Add("Tipo A");
            cmbTipos.Items.Add("Tipo B");

            //dispara SelecIndexChanged 

            cmbTipos.SelectedIndex = 0; 
            
            txtDias.Text = "";
            
            optEfectivo.Checked = true;
            txtNombre.Text = "";
            txtTelefono.Text = "";
            
            cmbTarjetas.Items.Clear();
            cmbTarjetas.Items.Add("Card Red");
            cmbTarjetas.Items.Add("Card Green");
            cmbTarjetas.Items.Add("Card Blue");

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cmbTipos_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (cmbTipos.SelectedIndex != -1) //es lo mismo que (.Text != "")
            //este hace que si no hay nada no se habilite -1 es que no esta seleccionado
            //{
            //    cmbPersonas.Enabled = true;
            //}
            //else
            //{
            //    cmbPersonas.Enabled = false;
            //}

            int I = 0; //Int 
            
            cmbPersonas.Items.Clear();
            
            if (cmbTipos.SelectedIndex == 0) //O puede ser cmbTipos.SelectedItem == "Tipo A"
            {
                for (I = 1; I <= 4; I++)
                {
                    cmbPersonas.Items.Add(I);
                }
            }
            else //al ya declarar que si es tipo a cargue de 1 a 4
                 //con el else nos referimos al Tipo B
            { 
                for (I = 1; I <= 8; I++)
                {
                    cmbPersonas.Items.Add(I);
                }
            }

            cmbPersonas.SelectedIndex = 0; //Selecciona el Item 0 del combo
            
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

            //declaro la condicion para activar btnAceptar
            if (txtDias.Text != "" && txtDias.Text != "0" && txtNombre.Text != "" 
                && txtTelefono.Text != "")
            {
                btnAceptar.Enabled = true;
            }
            else
            {
                btnAceptar.Enabled = false;
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

            //declaro la condicion para activar btnAceptar
            if (txtDias.Text != "" && txtDias.Text != "0" && txtNombre.Text != ""
                && txtTelefono.Text != "")
            {
                btnAceptar.Enabled = true;
            }
            else
            {
                btnAceptar.Enabled = false;
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

            //declaro la condicion para activar btnAceptar
            if (txtDias.Text != "" && txtDias.Text != "0" && txtNombre.Text != "" 
                && txtTelefono.Text != "")
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

            Dias = int.Parse(txtDias.Text); //cant. dias ingresados / Int Enteros

            //determina el tipo de cabaña para el precio base
            if (cmbTipos.SelectedIndex == 0)
            {
                PrecioBase = TIPOA;
            }
            else
            {
                PrecioBase = TIPOB;
            }
            
            //precio base + importe x persona (1usd)
            PrecioBase = PrecioBase + (PORPERSONA * int.Parse(cmbPersonas.Text));

            //controla adicionales           
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
            
            //saca el total por cant. de dias
            Total = (PrecioBase + Opcionales) * Dias;
    
            //controla forma pago
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
            
            //mensaje para el resultado

            MessageBox.Show("Total = " + Total.ToString(), "Importe de la reserva",
            MessageBoxButtons.OK, MessageBoxIcon.Information);

            //reinicia los controles

            cmbTipos.SelectedIndex = 0;
            txtDias.Text = "";
            chkCocina.Checked = false;
            chkHeladera.Checked = false;
            chkTele.Checked = false;
            optEfectivo.Checked = true;
            txtNombre.Text = "";
            txtTelefono.Text = "";

            
        }

        //hace que en el txt solo se puedan escribir numeros
        //KeyPress es un evento, !Char unico caracter
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
