using BookProjectHw.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookProjectHw.Business
{
    public interface IAuthorService
    {
        void GetList();
        void Add(Author author);
        void Delete(int id);
        void Update(Author author);
    }
}
