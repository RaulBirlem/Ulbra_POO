using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aula12_ef_test.Domain.Interfaces;
using aula12_ef_test.Data;
using aula12_ef_test.Domain.Entities;

namespace aula12_ef_test.Data.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly DataContext context;
        public UserRepository()
        {
            this.context = new DataContext();
        }
        public IList<User> GetAll()
        {
            return context.User.ToList();
        }
        public void Save(User entity)
        {
            context.Add(entity);
            context.SaveChanges();
        }
        public bool Delete(int entityId)
        {
            var user = GetById(entityId);
            context.Remove(user);
            context.SaveChanges();
            return true;
        }



        public User GetById(int entityId)
        {
            return context.User.SingleOrDefault(x=>x.Id == entityId);
        }



        public void Update(User entity)
        {
            context.User.Update(entity);
            context.SaveChanges();
        }
    }
}