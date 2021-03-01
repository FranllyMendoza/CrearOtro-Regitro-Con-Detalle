using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrearOtro_Regitro_Con_Detalle.Entidades
{
    public class Permisos
    {
        [Key]
        public int PermisoId { get; set; }
        public string Permiso { get; set; }

        [ForeignKey("PermisoId")]
        public virtual Permisos permiso { get; set; }

        public Permisos()
        {
            PermisoId = 0;
            Permiso = string.Empty;
        }
    }
}
