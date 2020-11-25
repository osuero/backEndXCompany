using Api.Business.Repositories;
using Api.Data;
using Api.Data.Entities;

namespace Api.Business.EntitiesRepository
{
    public class PermissionRepository : GenericRepository<Permission>
    {
        public PermissionRepository(ApiDbContext _context) : base(_context)
        {

        }
    }
}
