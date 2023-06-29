using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula12_ef_test.Domain.Entities
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public Author Author { get; set; }
        public User User { get; set; }
    }
}