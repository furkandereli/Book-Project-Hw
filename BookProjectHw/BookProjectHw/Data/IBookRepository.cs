using BookProjectHw.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookProjectHw.Data;

public interface IBookRepository : IEntityBaseRepository<Book, int>
{
    public Book GetByIsbn(string isbn);
}
