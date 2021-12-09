using Books.API.Models.Books;
using Books.Core.Domain.Books;
using Microsoft.AspNetCore.Mvc;

namespace Books.Web.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BooksController : ControllerBase
    {
        private readonly IBooksWriter _booksWriter;
        private readonly IBooksReader _booksReader;
        public BooksController(IBooksWriter booksWriter)
        {
            _booksWriter = booksWriter;
        }
        [HttpGet("{id}")]
        public async Task<BooksModel> GetBooks(string id)
        {
            var data = await _booksReader.GetBook(id);
            return data;
        }
        [HttpGet("{getAll}")]
        public async Task<List<BooksModel>> GetBooks()
        {
            var data = await _booksReader.GetAllBooks();
            return data;
        }
        [HttpPost]
        public async Task<BooksModel> SaveBooks([FromBody] BooksModel booksModel)
        {
            var id = await _booksWriter.SaveBooks(booksModel);
            booksModel.Id = id;
            return booksModel;

        }
        [HttpDelete("{id}")]
        public async Task<string> DeleteBook(string id)
        {
            var newId = await _booksWriter.DeleteBooks(id);
            return newId;
        }
    }

}
