using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Amazon.Models.ViewModels
{
    public class BooksViewModel // this stores info about the pageInfo as well as the bookstore dataset that's coming from the repository
    {
        public IQueryable<Book> Books { get; set; }
        public PageInfo PageInfo { get; set; }
    }
}
