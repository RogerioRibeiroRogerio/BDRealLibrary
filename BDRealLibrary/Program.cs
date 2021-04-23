using Microsoft.EntityFrameworkCore;
using System;

namespace BDRealLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Data Base Real Library");

            {
                static void Main(string[] args)
                {
                    Console.WriteLine("Hello World!");
                }
            }
        }

    class BDRealLIB : DbContext
        {
            public DbSet<Author> Autores { get; set; }
            public DbSet<Catgory> Categorias { get; set; }
            public DbSet<RentBook> Controles { get; set; }
            public DbSet<Editor> Editoras { get; set; }
            public DbSet<Book> Livros { get; set; }
            public DbSet<RentUser> Utentes { get; set; }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=BDBiblioteca;Trusted_Connection=True;");
            }
        }
    }
}
