using BookProjectHw.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookProjectHw.Data
{
    public class AuthorRepository : IAuthorRepository
    {
        private readonly List<Author> _authors;
        public AuthorRepository() 
        {
            _authors = new List<Author>()
            {
                new Author() {Id = 1, Name = "Stefan Zweig"},
                new Author() {Id = 2, Name = "Zülfü Livaneli"},
                new Author() {Id = 3, Name = "J.K. Rowling"},
                new Author() {Id = 4, Name = "Tolstoy"},
                new Author() {Id = 5, Name = "Cemal Süreya"},
                new Author() {Id = 6, Name = "Orhan Pamuk"},
                new Author() {Id = 7, Name = "Necip Fazıl Kısakürek"},
                new Author() {Id = 8, Name = "Özdemir Asaf"},
                new Author() {Id = 9, Name = "Franz Kafka"},
                new Author() {Id = 10, Name = "Paulo Coelho"}
            };
        }

        public void Add(Author author)
        {
            _authors.Add(author);
        }

        public void Delete(int id)
        {
            Author? author = _authors.Where(author => author.Id == id).SingleOrDefault();
            try
            {
                if (author != null)
                {
                    _authors.Remove(author);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }

        public List<Author> GetAll()
        {
            return _authors;
        }

        public Author? GetById(int id)
        {
            Author? author = null;
            try
            {
                author = _authors.Where(author => author.Id == id).SingleOrDefault();                  
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return author;
        }
    }
}
