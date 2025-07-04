﻿using Blog.web.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace Blog.web.Data
{
    public class BlogDbContext: DbContext
    {
        public BlogDbContext(DbContextOptions options) : base(options)
        {
         }
        public DbSet<BloggPost> BloggPosts { get; set; }
        public DbSet<Tag> Tags { get; set; }
    }
}
