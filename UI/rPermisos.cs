using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrearOtro_Regitro_Con_Detalle.BLL;
using CrearOtro_Regitro_Con_Detalle.Entidades;

namespace CrearOtro_Regitro_Con_Detalle.UI
{
    public partial class rPermisos : Form
    {
        public rPermisos()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            IdNumericUpDown.Value = 0;
            PermisoTextBox.Clear();
            ErrorProvider.Clear();
        }

        private void LlenaCampo(Permisos permiso)
        {
            IdNumericUpDown.Value = permiso.PermisoId;
            PermisoTextBox.Text = permiso.Permiso;
        }

          

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            int id;
            Permisos permiso = new Permisos();
            int.TryParse(IdNumericUpDown.Text, out id);

            Limpiar();

            permiso = PermisosBLL.Buscar(id);

            if (permiso != null)
            {
                LlenaCampo(permiso);
            }
            else
            {
                MessageBox.Show("Permiso no encontrado", "Id no existente", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

       

        

    }
}
