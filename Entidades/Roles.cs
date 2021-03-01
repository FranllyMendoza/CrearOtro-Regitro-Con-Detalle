using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrearOtro_Regitro_Con_Detalle.Entidades
{
    public class Roles
    {
        [Key]
        public int RolId { get; set; }
        public string Descripcion { get; set; }

        public bool esActivo { get; set; }

        [ForeignKey("RolId")]
        public virtual List<RolesDetalle> Detalle { get; set; }

        public Roles()
        {
            RolId = 0;
            Descripcion = string.Empty;
            esActivo = false;

            Detalle = new List<RolesDetalle>();
        }
    }
}
