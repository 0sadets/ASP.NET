using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities
{
    public class Publisher
    {
        public int Id { get; set; }
        public string PublisherName { get; set; }

        public ICollection<Book>? Books { get; set; }
        public int BookCount { get; set; }
    }
}
