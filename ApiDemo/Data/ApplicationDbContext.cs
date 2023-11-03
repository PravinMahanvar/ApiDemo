﻿using ApiDemo.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiDemo.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<Book> Books { get; set; }
    }
}