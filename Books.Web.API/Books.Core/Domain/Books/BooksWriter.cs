using Books.API.Models.Books;
using Books.Data.Entities.Books;
using Books.Data.Writer;
using CricSmith.Core;


namespace Books.Core.Domain.Books
{
    public class BooksWriter : IBooksWriter
    {
        private readonly IBooksDataWriter _booksDataWriter;
        private readonly IObjectMapper _objectMapper;
        public BooksWriter(
            IBooksDataWriter booksDataWriter,
            IObjectMapper objectMapper)
        {
            _booksDataWriter = booksDataWriter;
            _objectMapper = objectMapper;
        }

        public async Task<string> DeleteBooks(string Id)
        {
            string Result = await _booksDataWriter.DeleteBooks(Id);
            return Result;
        }

        public async Task<string> SaveBooks(BooksModel Model)
        {

            var entity = _objectMapper.Map<BooksModel, BooksEntity>(Model);
            string Result = await _booksDataWriter.SaveBooks(entity);
            return Result;

        }
    }
}
