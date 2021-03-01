using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrearOtro_Regitro_Con_Detalle.Entidades;

namespace CrearOtro_Regitro_Con_Detalle.UI
{
    public partial class MainForms : Form
    {
        public MainForms()
        {
            InitializeComponent();
            this.PermisosToolStripMenuItem3.Click += new EventHandler(this.PermisosToolStripMenuItem3_ItemClicked);
            this.RolesToolStripMenuItem2.Click += new EventHandler(this.RolesToolStripMenuItem2_ItemClicked);
            this.UsuarioToolStripMenuItem.Click += new EventHandler(this.UsuarioToolStripMenuItem_ItemClicked);
        }

        private void PermisosToolStripMenuItem3_ItemClicked(object sender, EventArgs e)
        {
            var permisos = new rPermisos();
            permisos.MdiParent = this;
            permisos.Show();
        }

        private void RolesToolStripMenuItem2_ItemClicked(object sender, EventArgs e)
        {
            rRoles roles = new rRoles();
            roles.MdiParent = this;
            roles.Show();
        }

        private void UsuarioToolStripMenuItem_ItemClicked(object sender, EventArgs e)
        {
            rUsuarios usuarios = new rUsuarios();
            usuarios.MdiParent = this;
            usuarios.Show();
        }

        
    }
}
