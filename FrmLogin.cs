﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (textUsuario.Text == "papolo" && textContraseña.Text == "12345")
            {
                Formventa llamar = new Formventa();
                llamar.Show();
                MessageBox.Show("usuario registrado exitosamente");
            }
            else
            {
                
                MessageBox.Show("credenciales invalidas");           
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
