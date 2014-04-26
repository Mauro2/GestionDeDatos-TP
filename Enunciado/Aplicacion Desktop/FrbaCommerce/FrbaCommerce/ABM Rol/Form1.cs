namespace FrbaCommerce.ABM_Rol
{
    using System;
    using System.Windows.Forms;
    using FrbaCommerce.Core.Security;
    
    public partial class Form1 : Form
    {
        private readonly IRoleProvider _roleProvider;

        public Form1(IRoleProvider roleProvider)
        {
            _roleProvider = roleProvider;

            InitializeComponent();
        }

        private void buttonCrear_Click(object sender, EventArgs e)
        {
            _roleProvider.CreateRole(textBoxNombre.Text);
        }
    }
}
