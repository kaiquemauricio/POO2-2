﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFAPOO4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            AreaTriangulo a;
            a = new AreaTriangulo();

            a.setAltura(int.Parse(txtAltura.Text));
            a.setBasin(int.Parse(txtBase.Text));
            a.calcular();
            lblResultado.Text = a.getResultado().ToString();

        }
    }
}
