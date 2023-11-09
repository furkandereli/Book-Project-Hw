using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookProjectHw.Exceptions
{
    public class BookNotFoundException : Exception
    {
        public BookNotFoundException(int id) :
            base($"Id : {id}, ye ait kitap bulunamadı.")
        {
        }
    }
}
