using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Amazon.Models
{
    public interface IAmazonRepository
    {
        IQueryable<Book> Books { get; }   // this is a class that is set up specifically for querying tables

    }
}
