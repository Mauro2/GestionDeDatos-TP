﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaCommerce
{
    public partial class Form1 : Form
    {
        public readonly Func<FormType, Form> _formFactory;

        public Form1(Func<FormType, Form> formFactory)
        {
            _formFactory = formFactory;
            InitializeComponent();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _formFactory(FormType.AltaCliente).Show();
        }

        private void rolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _formFactory(FormType.AltaRol).Show();
        }
    }
}
