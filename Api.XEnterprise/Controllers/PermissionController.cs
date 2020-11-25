using Api.Business.EntitiesRepository;
using Api.Data.Entities;
using Api.XEnterprise.Mappers;
using AutoMapper;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Api.XEnterprise.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PermissionController : BaseApiCotroller<Permission, Mappers.PermissionDto>
    {
        public PermissionController(IMapper mapper, PermissionRepository repository) : base(mapper, repository)
        {
        }

        [HttpGet]
        [Route("[action]")]
        public virtual IActionResult PermissionList()
        {
            var result = _repository.GetAll().Include(Permission => Permission.PermissionType).ToList().OrderBy(x=>x.Id);

            return Ok(_mapper.Map<List<PermissionDto>>(result));
        }
    }
}