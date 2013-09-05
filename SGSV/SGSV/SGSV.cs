﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SGSV.DAL;
using SGSV.Entidades;

namespace SGSV
{
    public partial class frmSGSV : Form
    {
        public frmSGSV()
        {
            InitializeComponent();
        }

        private void mniCrearLocalidad_Click(object sender, EventArgs e)
        {
            new Localidad.frmEditarLocalidad().ShowDialog();
        }

        private void mniListarLocalidad_Click(object sender, EventArgs e)
        {
            new Localidad.frmListarLocalidades().ShowDialog();
        }

        private void crearSucursal_Click(object sender, EventArgs e)
        {
            new Sucursal.frmCrearSucursal().ShowDialog();
        }

        private void listarSucursal_Click(object sender, EventArgs e)
        {
            new Sucursal.ListarSucursales().ShowDialog();
        }
    }
}