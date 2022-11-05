using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using BorrowBooks.Models;

namespace BorrowBooks.Data
{
    public class MyContext : DbContext
    {
        //public MyContext(DbContextOptions options) : base(options)
        //{

        //}
        public DbSet<Book> Books { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Library> Librarys { get; set; }
    }
}