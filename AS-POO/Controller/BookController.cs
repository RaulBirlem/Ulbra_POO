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
    public class BookController : ControllerBase
    {
        private readonly IBookRepository _repository;
        private readonly BookService _bookService;

        public BookController(IBookRepository repository, BookService bookService)
        {
            _repository = repository;
            _bookService = bookService;
        }

        [HttpGet]
        public IEnumerable<Book> Get()
        {
            return _repository.GetAll();
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var item = _repository.GetById(id);
            if (item == null)
                return Ok(new { statusCode = 400, message = "Nada foi encontrado com esse id." });
            else
                return Ok(new { statusCode = 200, message = "Ok", item });
        }

        [HttpPost]
        public IActionResult Post([FromBody] BookDTO item)
        {
            if (item is null)
            {
                throw new ArgumentNullException(nameof(item));
            }

            _bookService.CreateBook(item.Name, item.Price, item.AuthorId, item.UserId);

            return Ok(new
            {
                statusCode = 200,
                message = "Cadastrado com sucesso."
            });
        }

        [HttpPut]
        public IActionResult Put([FromBody] Book item)
        {
            _repository.Update(item);
            return Ok(new
            {
                statusCode = 200,
                message = "Atualizado com sucesso.",
                item
            });
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            if (_repository.Delete(id))
                return Ok(new { StatusCode = 200, message = "Deletado com sucesso!" });
            else
                return Ok(new { StatusCode = 500, message = "Algo deu errado!" });
        }
    }
}
