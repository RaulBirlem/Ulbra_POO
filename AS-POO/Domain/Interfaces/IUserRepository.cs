using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aula12_ef_test.Domain.Entities;

namespace aula12_ef_test.Domain.Interfaces
{
    public interface IUserRepository : IBaseRepository<User>
    {
        
    }
}