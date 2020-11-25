using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Api.XEnterprise.Mappers
{
    public class PermissionTypeDto
    {
        public int Id { get; set; }

        [DataType(DataType.Text)]
        [Required(ErrorMessage = "A description is required")]
        public string Descripcion { get; set; }

        //public virtual ICollection<PermissionDto> Permissions { get; set; }
    }
}
