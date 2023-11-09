using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookProjectHw.Exceptions;

public class BookNotFoundWithIsbn : Exception
{
    public BookNotFoundWithIsbn(string isbn) :
        base($"Isbn : {isbn}'ye ait kitap bulunamadı !")
    {
    }
}
