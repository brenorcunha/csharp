﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EngenSoftware
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(txtNumero.Text);
            if (num > 0)
            {
                lblResposta.Text = "Número positivo.";
            }
            else if (num < 0) {
                lblResposta.Text = "Número negativo.";
                } else {
                lblResposta.Text = "Você digitou zero!";
                }
        }
    }
}
