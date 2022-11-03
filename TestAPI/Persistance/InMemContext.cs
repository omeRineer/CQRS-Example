using Microsoft.EntityFrameworkCore;
using System;
using TestAPI.Models;

namespace TestAPI.Persistance
{
    public class InMemContext:DbContext
    {
        public InMemContext(DbContextOptions<InMemContext> options)
            : base(options)
        {

        }
        public DbSet<Product> Products { get; set; }
    }
}
