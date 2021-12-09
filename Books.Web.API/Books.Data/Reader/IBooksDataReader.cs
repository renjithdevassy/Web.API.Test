using Books.API.Models.Books;
using Books.Data.Entities.Books;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books.Data.Reader
{
    public interface IBooksDataReader
    {
        Task<BooksEntity> GetBooks(string Id);
        Task<List<BooksEntity>> GetAllBooks();
    }
}
