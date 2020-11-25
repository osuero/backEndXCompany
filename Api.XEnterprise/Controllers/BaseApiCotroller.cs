using System.Collections.Generic;
using System.Linq;
using Api.Business.Repositories;
using Api.Data.CommonEntitiesProperty;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace Api.XEnterprise.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseApiCotroller<T, TD> : ControllerBase
      where T : GenericEntity
      where TD : class
    {
        protected readonly GenericRepository<T> _repository;
        protected readonly IMapper _mapper;

        public BaseApiCotroller(IMapper mapper, GenericRepository<T> repository)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public List<T> Get()
        {
            var result = _repository.GetAll();
            return result.ToList();
        }

        [HttpGet("{id}")]
        public string Get(int id)
        {
            var objectEntity = _repository.Find(x => x.Id == id);

            return objectEntity.ToString();
        }

        [HttpPost]
        public void Post([FromBody] TD body)
        {
            var resource = _mapper.Map<T>(body);

            _repository.Add(resource);
            _repository.Save();
        }

        [HttpPut]
        public void Put([FromBody] T value)
        {
            _repository.Edit(value);
            _repository.Save();

        }

        [HttpDelete]
        public void Delete([FromBody] T value)
        {
            _repository.Delete(value);
            _repository.Save();
        }
    }
}
