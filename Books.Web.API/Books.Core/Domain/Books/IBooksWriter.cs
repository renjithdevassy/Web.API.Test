using Books.API.Models.Books;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books.Core.Domain.Books
{
    public interface IBooksWriter
    {
        Task<string> SaveBooks(BooksModel Model);
        Task<string> DeleteBooks(string Id);
    }
}
