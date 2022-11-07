using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace BorrowBooks.Models
{
    class MyContext : DbContext
    {
        //public M(DbContextOptions options) : base(options)
        //{

        //}
        public DbSet<Book> Books { get; set; }
        public DbSet<User> Users { get; set; }
    }
}