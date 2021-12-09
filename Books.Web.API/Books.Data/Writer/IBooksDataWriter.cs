using Books.Data.Entities.Books;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books.Data.Writer
{
    public interface IBooksDataWriter
    {
        Task<string> SaveBooks(BooksEntity entity);
        Task<string> DeleteBooks(string id);
    }
}
