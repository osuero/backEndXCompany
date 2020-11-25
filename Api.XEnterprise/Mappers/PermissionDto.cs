using System;
using System.ComponentModel.DataAnnotations;

namespace Api.XEnterprise.Mappers
{
    public class PermissionDto
    {
        public int Id { get; set; }

        [DataType(DataType.Text)]
        [Required(ErrorMessage = "The employee name cannot be empty")]
        public string NombreEmpleado { get; set; }

        [DataType(DataType.Text)]
        [Required(ErrorMessage = "The last name field cannot be empty")]
        public string ApellidosEmpleado { get; set; }
        
        [DataType(DataType.DateTime)]
        [Required(ErrorMessage = "The date field cannot be empty")]
        public DateTime FechaPermiso { get; set; }

        [Required(ErrorMessage = "Permission field cannot be empty")]
        public int TipoPermiso { get; set; }
        public virtual PermissionTypeDto PermissionType { get; set; }
    }
}
