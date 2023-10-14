using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookWormHub.Data.Entities
{
    public class Review
    {
        public int ReviewId { get; set; }
        public int Rating { get; set; } // E.g., on a scale of 1 to 5.
        public string Comment { get; set; } = string.Empty;

        [ForeignKey("UserId")]
        public User User { get; set; }

        [ForeignKey("BookId")]
        public Book Book { get; set; }
    }
}
