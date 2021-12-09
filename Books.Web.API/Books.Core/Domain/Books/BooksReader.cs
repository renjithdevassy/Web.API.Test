using Books.API.Models.Books;
using Books.Data.Entities.Books;
using Books.Data.Reader;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books.Core.Domain.Books
{
    public class BooksReader : IBooksReader
    {
        private readonly IBooksDataReader _booksDataReader;
        private readonly IObjectMapper _objectMapper;
        public BooksReader(
            IBooksDataReader booksDataReader,
            IObjectMapper objectMapper)
        {
            _booksDataReader = booksDataReader;
            _objectMapper = objectMapper;
        }

        public async Task<List<BooksModel>> GetAllBooks()
        {
           
            var model = await _booksDataReader.GetAllBooks();
            var entry = _objectMapper.Map<List<BooksEntity>, List<BooksModel>>(model.ToList<BooksEntity>());
            return entry;
        }

        public async Task<BooksModel> GetBook(string Id)
        {
            var model = await _booksDataReader.GetBooks(Id);
            var entry = _objectMapper.Map<BooksEntity, BooksModel>(model);
            return entry;
        }
    }
}
