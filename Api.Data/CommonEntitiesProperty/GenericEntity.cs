using Api.Data.ICommonEntitiesProperty;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api.Data.CommonEntitiesProperty
{
    public class GenericEntity : IGenericEntity
    {
        [Key]
        [DatabaseGenerated(databaseGeneratedOption: DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
    }
}
