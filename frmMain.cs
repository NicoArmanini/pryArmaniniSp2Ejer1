﻿using System;
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
            if (cmbTipos.Text != "")
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
    }
}
