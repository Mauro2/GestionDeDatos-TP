using System;
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
            ShowForm(FormType.AltaCliente);
        }

        private void rolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm(FormType.ListadoRol);
        }

        private void ShowForm(FormType formType)
        {
            Form f = _formFactory(formType);
            f.MdiParent = this;
            
            f.ControlBox = false;
            f.MinimizeBox = false;
            f.MaximizeBox = false;

            f.FormBorderStyle = FormBorderStyle.None;
            f.ShowIcon = false;
            f.Dock = DockStyle.Fill;
            f.Show();
        }

        private void toolStripMenuItemAltas_Click(object sender, EventArgs e)
        {

        }
    }
}
