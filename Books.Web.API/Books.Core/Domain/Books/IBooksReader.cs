using Books.API.Models.Books;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books.Core.Domain.Books
{
    public interface IBooksReader
    {
        Task<BooksModel> GetBook(string Id);
        Task<List<BooksModel>> GetAllBooks();
    }
}
