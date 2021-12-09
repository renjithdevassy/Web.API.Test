using Books.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books.Data.Entities.Books
{
    [BsonCollection("Books")]
    public class BooksEntity : Document
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Cost { get; set; }
        public string Rating { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string CreatedId { get; set; }
        public string UpdatedId { get; set; }


    }
}
