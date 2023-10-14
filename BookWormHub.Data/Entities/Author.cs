using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookWormHub.Data.Entities
{
    public class Author
    {
        public int AuthorId { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string? Bio { get; set; }

        public ICollection<Book>? Books { get; set; }
        public ICollection<Review>? Reviews { get; set; }
    }
}
