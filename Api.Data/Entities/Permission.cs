using Api.Data.CommonEntitiesProperty;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api.Data.Entities
{
    public class Permission: GenericEntity
    {
        public string NombreEmpleado { get; set; }
        public string ApellidosEmpleado { get; set; }
        public DateTime FechaPermiso { get; set; }

        [ForeignKey("PermissionType")]
        public int TipoPermiso { get; set; }
        public PermissionType PermissionType { get; set; }
    }
}
