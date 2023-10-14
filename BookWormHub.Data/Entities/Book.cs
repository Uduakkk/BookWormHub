using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookWormHub.Data.Entities
{
    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Author { get; set; } = string.Empty;
        public int PublishedYear { get; set; }
        public BookGenre Genre { get; set; }
        public string Description { get; set; } = string.Empty;
        public string? CoverImage { get; set; }
        public DateTimeOffset DateCreated { get; set; } = DateTimeOffset.Now;


        public ICollection<Review>? Reviews { get; set; }
    }
}
