using Api.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Api.Data
{
    public class ApiDbContext: DbContext 
    {
        public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options)
        { 
        
        }

        public DbSet<Permission> Permissions { get; set; }
        public DbSet<PermissionType> PermissionTypes { get; set; }
    }
}
