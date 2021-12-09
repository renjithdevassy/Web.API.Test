using Books.Common;
using Books.Data.Entities.Books;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books.Data.Reader
{
    public class BooksDataReader : IBooksDataReader
    {
        private readonly IMongoRepository<BooksEntity> _books;
        public BooksDataReader(IMongoRepository<BooksEntity> books)
        {
            _books = books;
        }
        public async Task<List<BooksEntity>> GetAllBooks()
        {
            try
            {
                var data = _books.AsQueryable();
                return await Task.FromResult(data.ToList()); ;
            }
            catch (Exception ex) { throw ex; }
            
        }

        public async Task<BooksEntity> GetBooks(string Id)
        {
            try
            {
                return await _books.FindByIdAsync(Id);
            }
            catch (Exception ex) { throw ex; }
        }
    }
}
