using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookProjectHw.Exceptions
{
    public class AuthorNameException : Exception
    {
        public AuthorNameException(string AuthorName) :
            base("Yazar adı minimum 2 karakter olmalıdır")
        {
        }
    }
}
