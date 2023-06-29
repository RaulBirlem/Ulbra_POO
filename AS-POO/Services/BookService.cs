
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aula12_ef_test.Domain.Interfaces;
using aula12_ef_test.Data;
using aula12_ef_test.Domain.Entities;
public class BookService
{
    private readonly IAuthorRepository authorRepository;
    private readonly IUserRepository userRepository;
    private readonly IBookRepository bookRepository;

    public BookService(IAuthorRepository authorRepository, IUserRepository userRepository, IBookRepository bookRepository)
    {
        this.authorRepository = authorRepository;
        this.userRepository = userRepository;
        this.bookRepository = bookRepository;
    }

    public void CreateBook(string name, decimal price, int authorId, int userId)
    {
        Author author = authorRepository.GetById(authorId);
        User user = userRepository.GetById(userId);

        Book book = new Book
        {
            Name = name,
            Price = price,
            Author = author,
            User = user
        };

        bookRepository.Save(book);
    }
}
