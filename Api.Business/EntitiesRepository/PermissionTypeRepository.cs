using Api.Business.Repositories;
using Api.Data;
using Api.Data.Entities;

namespace Api.Business.EntitiesRepository
{
    public class PermissionTypeRepository : GenericRepository<PermissionType>
    {
        public PermissionTypeRepository(ApiDbContext _context) : base(_context)
        {

        }
    }
}
