using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aula12_ef_test.Domain.Interfaces;
using aula12_ef_test.Data;
using aula12_ef_test.Domain.Entities;

namespace aula12_ef_test.Data.Repositories
{
    public class BookRepository : IBookRepository
    {
        private readonly DataContext context;
        public BookRepository()
        {
            this.context = new DataContext();
        }
        public IList<Book> GetAll()
        {
            return context.Book.ToList();
        }
        public void Save(Book entity)
        {
            context.Add(entity);
            context.SaveChanges();
        }
        public bool Delete(int entityId)
        {
            var book = GetById(entityId);
            context.Remove(book);
            context.SaveChanges();
            return true;
        }



        public Book GetById(int entityId)
        {
            return context.Book.SingleOrDefault(x=>x.Id == entityId);
        }



        public void Update(Book entity)
        {
            context.Book.Update(entity);
            context.SaveChanges();
        }
    }
}