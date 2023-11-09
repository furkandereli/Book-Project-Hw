using BookProjectHw.Data;
using BookProjectHw.Exceptions;
using BookProjectHw.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookProjectHw.Business;

public class BookService : IBookService
{
    private readonly IBookRepository _bookRepository;

    public BookService(IBookRepository bookRepository)
    {
        _bookRepository = bookRepository;
    }

    // Ekleme işi yaparken kitap başlığı minimum 2 karakterli olmalıdır.
    // Price ve Stock Property leri - değer alamaz.

    public void Add(Book book)
    {
        // Validasyon kurallarından geçmeyen kitabı listeye eklemeyeceğiz.
        try
        {
            AddRules(book);
            _bookRepository.Add(book);
            GetList();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }


        // 1. Yöntem
        //catch (BookTitleException ex)
        //{
        //    Console.WriteLine(ex.Message);
        //}
        //catch (BookPriceAndStockException ex)
        //{
        //    Console.WriteLine(ex.Message);
        //}
    }

    public void Delete(int id)
    {
        try
        {
            _bookRepository.Delete(id);
            GetList();
        }
        catch (BookNotFoundException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    public void GetById(int id)
    {
        try
        {
            Book? book = _bookRepository.GetById(id);
            Console.WriteLine(book);

        }
        catch (BookNotFoundException ex)
        {
            Console.WriteLine(ex.Message);
        }

    }

    public void GetList()
    {
        List<Book> books = _bookRepository.GetAll();
        books.ForEach(book => Console.WriteLine(book));
    }
    private void AddRules(Book book)
    {
        if (book.Title.Length < 2)
        {
            throw new BookTitleException(book.Title);
        }

        if (book.Price < 0 || book.Stock < 0)
        {
            throw new BookPriceAndStockException(book.Price, book.Stock);
        }
    }
}
