﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;


 namespace proyectoCalificaciones
{
    public partial class frmInforme : Form
    {
        
        public frmInforme()
        {
            InitializeComponent();
        }

        public void Informe_Load(object sender, EventArgs e)
        {
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
      
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
      
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            Process.Start("ArchivoInforme.txt");
        }
    }
}
