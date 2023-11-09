using BookProjectHw.Consts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookProjectHw.Exceptions;

public class BookTitleException : Exception
{
    public BookTitleException(string title) : base(Messages.BookTitleExceptionMessage(title)) { }
}
