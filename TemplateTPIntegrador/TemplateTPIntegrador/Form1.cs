﻿using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TemplateTPIntegrador
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ValidacionesUtils validacionesUtils = new ValidacionesUtils();

            string usuario = textUsername.Text;

            validacionesUtils.ValidarStringVacio(usuario);    

            LoginNegocio ln = new LoginNegocio();
            ln.Login();

        }

        private void textUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
