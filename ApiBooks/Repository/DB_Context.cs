using ApiBooks.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiBooks.Repository
{
    public class DB_Context:DbContext
    {
        public DB_Context(DbContextOptions<DB_Context> options) : base(options)
        {
        }
        public DbSet<Book> Books { get; set; }
    }
}
