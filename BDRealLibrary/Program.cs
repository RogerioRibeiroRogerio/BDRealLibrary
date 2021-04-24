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
            public DbSet<Author> Authors { get; set; }
            public DbSet<Catgory> Catgorys { get; set; }
            public DbSet<RentBook> Controls { get; set; }
            public DbSet<Editor> Editors { get; set; }
            public DbSet<Book> Books { get; set; }
            public DbSet<RentUser> RentUsers { get; set; }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=BDBiblioteca;Trusted_Connection=True;");
            }
        }
    }
}
