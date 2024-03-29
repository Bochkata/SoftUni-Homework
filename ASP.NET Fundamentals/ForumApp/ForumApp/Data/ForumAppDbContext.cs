﻿using ForumApp.Data.Entities;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.EntityFrameworkCore;

namespace ForumApp.Data
{
    public class ForumAppDbContext : DbContext
    {
        //private Post FirstPost { get; set; }
        //private Post SecondPost { get; set; }
        //private Post ThirdPost { get; set; }

        public ForumAppDbContext(DbContextOptions<ForumAppDbContext> options) : base(options)
        {

            //this.Database.Migrate();
        }

        public DbSet<Post> Posts { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {

            builder.ApplyConfiguration<Post>(new PostConfiguration());

            builder.Entity<Post>()
                .Property(p => p.IsDeleted)
                .HasDefaultValue(false);
            //SeedPosts();
            //builder.Entity<Post>()
            //    .HasData(FirstPost, SecondPost, ThirdPost);

            base.OnModelCreating(builder);
        }
       
        //private void SeedPosts()
        //{
        //    FirstPost = new Post
        //    {
        //        Id = 1,
        //        Title = "My first post",
        //        Content = "My first post will be about performing CRUD operations in MVC. It's so much fun!"
        //    };
        //    SecondPost = new Post
        //    {
        //        Id = 2,
        //        Title = "My second post",
        //        Content = "This is my second post. CRUD operations in MVC are getting more and more interesting!"
        //    };
        //    ThirdPost = new Post
        //    {
        //        Id = 3,
        //        Title = "My third post",
        //        Content = "Hello there! I'm getting better and better with the CRUD operations in MVC. Stay tuned!"
        //    };
        
    }
}
