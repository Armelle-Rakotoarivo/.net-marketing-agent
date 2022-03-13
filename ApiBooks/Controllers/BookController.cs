using ApiBooks.Models;
using ApiBooks.Repository;
using ApiBooks.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiBooks.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBook book;
        
        public BookController(IBook _book) {
            book = _book;
        }
        // GET: api/<BookController>
        [HttpGet]
        public IEnumerable<Book> Get(string title)
        {
            return book.GetBooks(title);
        }

        // GET api/<BookController>/5
        [HttpGet("{id}")]
        public Book Get(int id)
        {
            return book.GetBook(id);
        }

        // POST api/<BookController>
        [HttpPost]
        public Status Post([FromBody] Book value)
        {
            return book.Add(value);
        }

        [HttpPost("{id}")]
        public Status Sell(int id)
        {
           return book.Sell(id);
           
        }
        // PUT api/<BookController>/5
        [HttpPut("{id}")]
        public Status Put(int id, [FromBody] Book value)
        {
            return book.Update(id, value);
        }

        // DELETE api/<BookController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
