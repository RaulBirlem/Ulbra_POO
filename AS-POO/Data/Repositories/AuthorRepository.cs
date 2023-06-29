using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aula12_ef_test.Domain.Interfaces;
using aula12_ef_test.Data;
using aula12_ef_test.Domain.Entities;

namespace aula12_ef_test.Data.Repositories
{
    public class AuthorRepository : IAuthorRepository
    {
        private readonly DataContext context;
        public AuthorRepository()
        {
            this.context = new DataContext();
        }
        public IList<Author> GetAll()
        {
            return context.Author.ToList();
        }
        public void Save(Author entity)
        {
            context.Add(entity);
            context.SaveChanges();
        }
        public bool Delete(int entityId)
        {
            var author = GetById(entityId);
            context.Remove(author);
            context.SaveChanges();
            return true;
        }



        public Author GetById(int entityId)
        {
            return context.Author.SingleOrDefault(x=>x.Id == entityId);
        }



        public void Update(Author entity)
        {
            context.Author.Update(entity);
            context.SaveChanges();
        }
    }
}