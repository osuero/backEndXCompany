using Api.Business.EntitiesRepository;
using Api.Data.Entities;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace Api.XEnterprise.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PermissionTypeController : BaseApiCotroller<PermissionType, Mappers.PermissionTypeDto>
    {
        public PermissionTypeController(IMapper mapper, PermissionTypeRepository repository) : base(mapper, repository)
        {
        }
    }
}