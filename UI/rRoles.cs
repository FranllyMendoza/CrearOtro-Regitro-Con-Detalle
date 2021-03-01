using CrearOtro_Regitro_Con_Detalle.BLL;
using CrearOtro_Regitro_Con_Detalle.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrearOtro_Regitro_Con_Detalle.UI
{
    public partial class rRoles : Form
    {
        public List<RolesDetalle> Detalle { get; set; }
        public rRoles()
        {
            InitializeComponent();
            this.Detalle = new List<RolesDetalle>();

            PermisosComboBox.DataSource = PermisosBLL.GetPermisos();
            PermisosComboBox.DisplayMember = "PermisoId";
            PermisosComboBox.ValueMember = "Permiso";
        }

        private void CargarGrid()
        {
            DetallesDataGridView.DataSource = null;
            DetallesDataGridView.DataSource = this.Detalle;
        }

        private void Limpiar()
        {
            ErrorProvider.Clear();
            bool paso = false;

            IdNumericUpDown.Value = 0;
            DescripcionTextBox.Clear();
            ErrorProvider.Clear();
            RolActivoCheckBox.Checked = paso;
            AsignadoCheckBox.Checked = paso;
           //PermisosComboBox.Items.Clear();
            this.Detalle = new List<RolesDetalle>();
            CargarGrid();
        }

        private void LlenaCampo(Roles rol)
        {
            IdNumericUpDown.Value = rol.RolId;
            DescripcionTextBox.Text = rol.Descripcion;
            RolActivoCheckBox.Checked = rol.esActivo;

            this.Detalle = rol.Detalle;
            CargarGrid();
        }

        private Roles LlenaClase()
        {
            Roles rol = new Roles();

            rol.RolId = (int)IdNumericUpDown.Value;
            rol.Descripcion = DescripcionTextBox.Text;
            rol.esActivo = RolActivoCheckBox.Checked;

            rol.Detalle = this.Detalle;
            CargarGrid();

            return rol;
        }
        private bool ExisteEnLaBaseDeDatos()
        {
            Roles rol = RolesBLL.Buscar((int)IdNumericUpDown.Value);

            return (rol != null);
        }

        private bool Validar()
        {
            bool paso = true;
            ErrorProvider.Clear();

            if (DescripcionTextBox.Text == string.Empty)
            {
                ErrorProvider.SetError(DescripcionTextBox, "El campo Rol no puede estar vacío");
                DescripcionTextBox.Focus();
                paso = false;
            }
            if (RolesBLL.ExisteDescripcion(DescripcionTextBox.Text, (int)IdNumericUpDown.Value))
            {
                ErrorProvider.SetError(DescripcionTextBox, "Este Rol ya existe");
                DescripcionTextBox.Focus();
                paso = false;
            }
            if(PermisosComboBox.Text == string.Empty)
            {
                ErrorProvider.SetError(PermisosComboBox, "Debe seleccionar un Id");
                PermisosComboBox.Focus();
                paso = false;
            }
            if(this.Detalle.Count == 0)
            {
                ErrorProvider.SetError(DetallesDataGridView, "Debe agregar un Permiso");
                PermisosComboBox.Focus();
                paso = false;
            }

            return paso;
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            int id;
            Roles rol = new Roles();
            int.TryParse(IdNumericUpDown.Text, out id);

            Limpiar();

            rol = RolesBLL.Buscar(id);

            if (rol != null)
            {
                LlenaCampo(rol);
            }
            else
            {
                MessageBox.Show("Rol no encontrado", "Id no existente", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            Roles rol;
            bool paso = false;

            if (!Validar())
                return;

            rol = LlenaClase();

            paso = RolesBLL.Guardar(rol);

            if (paso)
            {
                Limpiar();
                MessageBox.Show("se guardo exitosamente!", "exito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("no se guardo exitosamente", "Fallo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            ErrorProvider.Clear();
            int id;
            int.TryParse(IdNumericUpDown.Text, out id);

            Limpiar();

            if (RolesBLL.Eliminar(id))
                MessageBox.Show("Eliminado Correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                ErrorProvider.SetError(IdNumericUpDown, "Id no existe");
        }

        private void AgregarButton_Click(object sender, EventArgs e)
        {
            bool paso = false;
            if (DetallesDataGridView.DataSource != null)
                this.Detalle = (List<RolesDetalle>)DetallesDataGridView.DataSource;

            this.Detalle.Add(
                new RolesDetalle(
                    id: 0,
                    rolId: (int)IdNumericUpDown.Value,
                    permisoId: Convert.ToInt32(PermisosComboBox.Text),
                    esasignado: AsignadoCheckBox.Checked
                )
            );
            CargarGrid();
            PermisosComboBox.Focus();
            //PermisosComboBox.Items.Clear();
            AsignadoCheckBox.Checked = paso;
        }

        private void RemoverButton_Click(object sender, EventArgs e)
        {
            if((DetallesDataGridView.Rows.Count > 0) && (DetallesDataGridView.CurrentRow != null))
            {
                Detalle.RemoveAt(DetallesDataGridView.CurrentRow.Index);
                CargarGrid();
            }
        }
    }
}
