using System.ComponentModel.DataAnnotations;

namespace Api.Data.ICommonEntitiesProperty
{
    public interface IGenericEntity
    {
        [Key]
        int Id { get; set; }
    }
}
