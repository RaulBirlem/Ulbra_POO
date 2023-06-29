using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using aula12_ef_test.Domain.Interfaces;
using aula12_ef_test.Data;
using aula12_ef_test.Domain.Entities;
using aula12_ef_test.Data.Repositories;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

IAuthorRepository authorRepository = new AuthorRepository();
IUserRepository userRepository = new UserRepository();
IBookRepository bookRepository = new BookRepository();

BookService bookService = new BookService(authorRepository, userRepository, bookRepository);

      
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IBookRepository, BookRepository>();
builder.Services.AddScoped<BookService>();
builder.Services.AddScoped<IAuthorRepository, AuthorRepository>();
builder.Services.AddScoped<IUserRepository, UserRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
