using aula12_ef_test.Domain.Interfaces;
using aula12_ef_test.Data;
using aula12_ef_test.Data.Repositories;
using aula12_ef_test.Domain.Entities;
public class BookDTO
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public int AuthorId { get; set; }
    public int UserId { get; set; }
}
