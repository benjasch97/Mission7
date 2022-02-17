using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Amazon.Models
{
    public class EFAmazonRepository : IAmazonRepository
    {
        private BookstoreContext context { get; set; }

        public EFAmazonRepository (BookstoreContext temp)
        {
            context = temp;
        }

        public IQueryable<Book> Books => context.Books;
    }
}
