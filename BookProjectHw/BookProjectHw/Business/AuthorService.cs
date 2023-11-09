using BookProjectHw.Data;
using BookProjectHw.Exceptions;
using BookProjectHw.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace BookProjectHw.Business
{
    public class AuthorService : IAuthorService
    {
        private readonly IAuthorRepository _authorRepository;

        public AuthorService(IAuthorRepository authorRepository)
        {
            _authorRepository = authorRepository;
        }

        public void Add(Author author)
        {
            try
            {
                if (author.Name.Length < 2)
                    throw new AuthorNameException(author.Name);
                
                _authorRepository.Add(author);
                GetList();
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void Delete(int id)
        {
            try
            {
                _authorRepository.Delete(id);
                GetList();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void GetList()
        {
            try
            {
                List<Author> authors = _authorRepository.GetAll();
                foreach (Author author in authors)
                {
                    Console.WriteLine($"Id : {author.Id} Yazar Adı : {author.Name}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void Update(Author author)
        {
            var value = _authorRepository.GetById(author.Id);
            if (value != null)
            {
                value.Name = author.Name;
            }
            else
                Console.WriteLine("Girdiğiniz id degeri için yazar bulunamadı. Güncelleme olmadı.");
        }
    }
}
