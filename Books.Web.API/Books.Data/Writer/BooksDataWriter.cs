using Books.Common;
using Books.Data.Entities.Books;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books.Data.Writer
{
    public class BooksDataWriter : IBooksDataWriter
    {
        private readonly IMongoRepository<BooksEntity> _booksEntity;
        public BooksDataWriter(IMongoRepository<BooksEntity> booksEntity)
        {
            _booksEntity = booksEntity;
        }

        public async  Task<string> DeleteBooks(string id)
        {
            try
            {
                await _booksEntity.DeleteByIdAsync(id);
                return id;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<string> SaveBooks(BooksEntity entity)
        {
            try
            {
                if (entity.Id != null)
                {
                    entity.UpdatedAt = DateTime.Now;
                    await _booksEntity.ReplaceOneAsync(entity);
                }
                else
                {
                    entity.CreatedAt = DateTime.Now;
                    await _booksEntity.InsertOneAsync(entity);
                }

                return entity.Id.ToString();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
