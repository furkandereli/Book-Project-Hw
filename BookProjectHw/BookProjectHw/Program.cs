using BookProjectHw.Models;
using BookProjectHw.Data;
using BookProjectHw.Business;


IBookService bookService = new BookService(new BookRepository());
//bookService.GetList();
IAuthorService authorService = new AuthorService(new AuthorRepository());

//BookRepository bookRepository = new BookRepository();
//bookRepository.GetByIsbn("adeasx");                      //Isbn kontrolü için deneme kodları
//bookRepository.GetByIsbn("abc123");

//Author author = new Author()
//{
//    Id = 11,
//    Name = "A"
//};

//Console.WriteLine("Yazar ekleme denemesi :");           // Yazar adı minimum 2 karakter olmalı kontrolü için deneme kodları
//authorService.Add(author);

Book book = new Book()
{
    Id = 5,
    Description = "Test",
    Price = 2500,
    Stock = -2000,
    Title = "Test"
};

Console.WriteLine("Tüm yazar listesi :");
authorService.GetList();

Author authorUpdate = new Author()
{
    Id = 1,
    Name = "Güncellenen Yazar"
};

Console.WriteLine("Kayıt Güncelleme");
authorService.Update(authorUpdate);

Console.WriteLine("Güncellendikten sonra liste");
authorService.GetList();

//Console.WriteLine("Kayıt ekleme : ");
//bookService.Add(book);
//Console.WriteLine("Kayıt silme : ");
//bookService.Delete(2);

//Console.WriteLine("Id ye göre getirme:");
//bookService.GetById(20);

//Console.WriteLine("Kitapların listesi");
//bookService.GetList();