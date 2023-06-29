using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aula12_ef_test.Domain.Interfaces;
using aula12_ef_test.Data.Repositories;
using aula12_ef_test.Data;
using aula12_ef_test.Domain.Entities;
using Microsoft.AspNetCore.Mvc;


namespace aula12_ef_test.Data.Repositories
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _repository;

        public UserController()
        {
            _repository = new UserRepository();
        }
 
        [HttpGet]
        public IEnumerable<User> Get()
        {
            return _repository.GetAll();
        }



        //IActionResult retorna em json

        public IActionResult Get(int id)
            {
                var item = _repository.GetById(id);
                if(item ==null)
                    return Ok(new {statusCode = 400, message="Nada foi encontrado com esse id."});
                else
                    return Ok(new {statusCode = 200, message="Ok",item});
            }

         [HttpPost]
        public IActionResult Post([FromBody]User item)
        {
            if (item is null)
            {
                throw new ArgumentNullException(nameof(item));
            }

            _repository.Save(item);
            return Ok(new {
                statusCode = 200,
                message = "Cadastrado com sucesso.",
                item });
        }
        [HttpPut]
        public IActionResult Put([FromBody]User item)
            {
                _repository.Update(item);
                return Ok(new {
                    statusCode = 200,
                    message = "Atualizado com sucesso.",
                    item });
            }



        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            if ( _repository.Delete(id)==true)
                return Ok(new {StatusCode=200, message= "Deletado com sucesso!"});
            else
                return Ok(new {StatusCode=500, message= "Algo deu errado!"});

        }


    }
}